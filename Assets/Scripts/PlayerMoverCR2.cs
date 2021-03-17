using cr2;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoverCR2 : Controller
{
    //PID SETTING
    const float p_gain = 1.0f;
    const float i_gain = 0.0f;
    const float d_gain = 0.00f;
    //private static int cr2Count = 0;

    public bool target_reached = false;

    public event EventHandler OnConnected,
                              OnDisconnected;
    const float RATIO_PWM_TORQUE = 1184f;
    const int INIT_PWM = 700;
    const float BACKOFF_GAIN = 0.99f;
    int error;

    const int LIMIT_MAX_PWM = 2300;
    int MAX_PWM = 2300; //set max torque to 2

    IntPtr device = (IntPtr)hkapi.HK_INVALID_HANDLE;
    bool connected = false;

    [HideInInspector]
    public int motor_position;
    public static int multiplier = 2;
    public static float leftTorque = -2;
    public static float rightTorque = 2;
    public string connectNotice;

    private float ratio_degree;
    private float ratio_newton;
    private int motor_current;
    private int motor_pwm;
    private int old_motor_pwm;
    private int HandleMidPos;
    bool firstInit = false;
    private int pwmLeft, pwmRight;
    int treshold = 300;

    public static float minRange = -90,
                        maxRange = 90;//set default range in degree

    private int target;
    private readonly object targetLocker = new object();
    public int Target
    {
        get
        {
            lock (targetLocker)
            {
                return target;
            }
        }
        set
        {
            lock (targetLocker)
            {
                target = value;
            }
        }
    }

    public void SetTarget(float ratio)
    {
        Target = (int)Utility.Math.Map(ratio, -80f, 80f, -180f, 180f);
        Debug.Log(Target);
        Target = (int)Utility.Math.Map(Target, -180f, 180f, 3300f, 15000f);

    }

    private bool isRightDirection;
    private readonly object isRightDirectionLocker = new object();
    public bool IsRightDirection
    {
        get
        {
            lock (isRightDirectionLocker)
            {
                return isRightDirection;
            }
        }
        set
        {
            lock (isRightDirectionLocker)
            {
                isRightDirection = value;
            }
        }
    }

    private bool isEnabled = false;
    private readonly object isEnabledLocker = new object();
    public bool IsEnabled
    {
        get
        {
            lock (isEnabledLocker)
            {
                return isEnabled;
            }
        }
        set
        {
            lock (isEnabledLocker)
            {
                isEnabled = value;
            }
        }
    }

    void Start()
    {
        CheckAndConnectDevice();
    }


    void OnDestroy()
    {
        hkapi.hkStopExternalControlLoop();
        hkapi.hkReleaseDevice(device);
        device = (IntPtr)hkapi.HK_INVALID_HANDLE;
        connected = false;
    }


    // Update is called once per frame
    void Update()
    {
        CheckAndConnectDevice();
        // Debug.Log(isEnabled.ToString());
    }
    public void assist(float targetpos)
    {

        // Debug.Log(targetpos);
        if (targetpos > 0)
        {
            hkapi.hkSetPwmAsync(100);
        }
        else
        {
            hkapi.hkSetPwmAsync(100);

            //Debug.Log("pwm set");
        }
    }

    void CheckAndConnectDevice()
    {
        if (!connected)
        {
            firstInit = false;
            // attempt to connect to device
            device = hkapi.hkInitDevice(null);
            connected = hkapi.hkIsConnected();

            if (connected)
            {
                hkapi.hkSetPacketFrequency(1000);
                if (!hkapi.hkGetRatioDegree(out ratio_degree) || !hkapi.hkGetRatioNewton(out ratio_newton))
                {
                    hkapi.hkReleaseDevice(device);
                    device = (IntPtr)hkapi.HK_INVALID_HANDLE;
                    connected = false;
                }
                else
                {
                    HandleMidPos = (int)(180f / ratio_degree);

                    //this not use 
                    pwmLeft = (int)(leftTorque * RATIO_PWM_TORQUE);
                    pwmRight = (int)(rightTorque * RATIO_PWM_TORQUE);

                    MAX_PWM = (int)(rightTorque * RATIO_PWM_TORQUE);
                    MAX_PWM = MAX_PWM > LIMIT_MAX_PWM ? LIMIT_MAX_PWM : MAX_PWM;
                }

                if (!hkapi.hkStartExternalControlLoop(this.HapticControl, device))
                {
                    hkapi.hkReleaseDevice(device);
                    device = (IntPtr)hkapi.HK_INVALID_HANDLE;
                    connected = false;
                }

                var onConnected = OnConnected;
                if (connected && onConnected != null)
                {
                    OnConnected.Invoke(this, EventArgs.Empty);
                }
            }
        }
        else
        {
            // update device connection status
            connected = hkapi.hkIsConnected();
            if (!connected)
            {
                hkapi.hkReleaseDevice(device);
                device = (IntPtr)hkapi.HK_INVALID_HANDLE;

                var onDisconnected = OnDisconnected;
                if (onDisconnected != null)
                {
                    onDisconnected.Invoke(this, EventArgs.Empty);
                }
            }
        }

        if (connected)
        {
            connectNotice = "";
        }
        else
        {
            connectNotice = "Disconnected, please check the connection!";
        }
    }
    float integralTerm;
    int oldError;

    private void HapticControl(IntPtr arg)
    {
        if (!hkapi.hkGetLastRawPositionAndCurrent(out motor_position, out motor_current)) return;


        if (!firstInit)
        {
            // compute motor pwm calculation test
            if (motor_position < HandleMidPos - treshold)
            {
                motor_pwm = INIT_PWM;
            }
            else if (motor_position > HandleMidPos + treshold)
            {
                motor_pwm = -INIT_PWM;
            }
            else
            {
                firstInit = true;
            }
        }

        if (IsEnabled == true)
        {

            //if (!target_reached)
            //{
            error = (Target - motor_position);

            //}
            //else
            //{
            //    error = 0;
            //}

            //if (error > 100)
            //{
            //    motor_pwm = 800;
            //    Debug.Log("yasta manyka");
            //}
            //else if (error < -100)
            //{
            //    motor_pwm = -800;
            //    Debug.Log("yasta manyka");
            //}
            //else
            //{
            //    motor_pwm = 0;
            //    target_reached = true;
            //}
            //Debug.Log(error);
            integralTerm += i_gain * (float)error;
            var deltaError = error - oldError;
            motor_pwm = Mathf.RoundToInt((p_gain * (float)error + integralTerm + d_gain * deltaError));
            oldError = error;


        }
        else
        {
            //Debug.Log("reached here");
            oldError = 0;
            integralTerm = 0;
            motor_pwm = Mathf.RoundToInt(BACKOFF_GAIN * (float)old_motor_pwm);
        }


        motor_pwm = motor_pwm > MAX_PWM ? MAX_PWM : motor_pwm;
        motor_pwm = motor_pwm < -MAX_PWM ? -MAX_PWM : motor_pwm;

        old_motor_pwm = motor_pwm;
        hkapi.hkSetPwmAsync(motor_pwm);
    }

    public override bool IsConnected
    {
        get
        {
            return connected;
        }
    }
    public override Vector3 GetInput()
    {
        //get degree in -180 to 180
        float hkDegree = Utility.Math.Map(motor_position, 3300, 15000, -180f, 180f);
        // Debug.Log(motor_position);


        //hkDegree = hkDegree > maxRange ? maxRange : hkDegree;
        //hkDegree = hkDegree < minRange ? minRange : hkDegree;
        float xAxis = Utility.Math.Map(hkDegree, -180f, 180f, -1f, 1f);
        return new Vector2(xAxis, 0f);
    }
}