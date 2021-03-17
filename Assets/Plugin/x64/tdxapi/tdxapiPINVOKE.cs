/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace cr2 {

class tdxapiPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="SWIGRegisterExceptionCallbacks_tdxapi")]
    public static extern void SWIGRegisterExceptionCallbacks_tdxapi(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_tdxapi")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_tdxapi(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_tdxapi(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_tdxapi(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(tdxapiPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(tdxapiPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="SWIGRegisterStringCallback_tdxapi")]
    public static extern void SWIGRegisterStringCallback_tdxapi(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_tdxapi(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static tdxapiPINVOKE() {
  }


  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXAPI_VERSION_MAJOR_get")]
  public static extern int TDXAPI_VERSION_MAJOR_get();

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXAPI_VERSION_MINOR_get")]
  public static extern int TDXAPI_VERSION_MINOR_get();

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_program_name_set")]
  public static extern void TDXInputData_program_name_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_program_name_get")]
  public static extern string TDXInputData_program_name_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_training_mode_set")]
  public static extern void TDXInputData_training_mode_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_training_mode_get")]
  public static extern int TDXInputData_training_mode_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_hand_set")]
  public static extern void TDXInputData_hand_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_hand_get")]
  public static extern int TDXInputData_hand_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_handle_type_set")]
  public static extern void TDXInputData_handle_type_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_handle_type_get")]
  public static extern int TDXInputData_handle_type_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_range_min_set")]
  public static extern void TDXInputData_range_min_set(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_range_min_get")]
  public static extern float TDXInputData_range_min_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_range_max_set")]
  public static extern void TDXInputData_range_max_set(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_range_max_get")]
  public static extern float TDXInputData_range_max_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_torque_left_set")]
  public static extern void TDXInputData_torque_left_set(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_torque_left_get")]
  public static extern float TDXInputData_torque_left_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_torque_right_set")]
  public static extern void TDXInputData_torque_right_set(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_torque_right_get")]
  public static extern float TDXInputData_torque_right_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_level_set")]
  public static extern void TDXInputData_level_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_level_get")]
  public static extern int TDXInputData_level_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_reps_set")]
  public static extern void TDXInputData_reps_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_reps_get")]
  public static extern int TDXInputData_reps_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_patient_get")]
  public static extern global::System.IntPtr TDXInputData_patient_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_new_TDXInputData")]
  public static extern global::System.IntPtr new_TDXInputData();

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_delete_TDXInputData")]
  public static extern void delete_TDXInputData(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_patient_name_set")]
  public static extern void TDXInputData_patient_name_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_patient_name_get")]
  public static extern string TDXInputData_patient_name_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_patient_age_set")]
  public static extern void TDXInputData_patient_age_set(global::System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_patient_age_get")]
  public static extern byte TDXInputData_patient_age_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_patient_gender_set")]
  public static extern void TDXInputData_patient_gender_set(global::System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_patient_gender_get")]
  public static extern byte TDXInputData_patient_gender_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_patient_height_set")]
  public static extern void TDXInputData_patient_height_set(global::System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_patient_height_get")]
  public static extern byte TDXInputData_patient_height_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_patient_weight_set")]
  public static extern void TDXInputData_patient_weight_set(global::System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXInputData_patient_weight_get")]
  public static extern byte TDXInputData_patient_weight_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_new_TDXInputData_patient")]
  public static extern global::System.IntPtr new_TDXInputData_patient();

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_delete_TDXInputData_patient")]
  public static extern void delete_TDXInputData_patient(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXResult_score_set")]
  public static extern void TDXResult_score_set(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXResult_score_get")]
  public static extern float TDXResult_score_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXResult_filename_set")]
  public static extern void TDXResult_filename_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXResult_filename_get")]
  public static extern string TDXResult_filename_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_new_TDXResult")]
  public static extern global::System.IntPtr new_TDXResult();

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_delete_TDXResult")]
  public static extern void delete_TDXResult(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXOutputData_reps_completed_set")]
  public static extern void TDXOutputData_reps_completed_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXOutputData_reps_completed_get")]
  public static extern int TDXOutputData_reps_completed_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXOutputData_duration_set")]
  public static extern void TDXOutputData_duration_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXOutputData_duration_get")]
  public static extern int TDXOutputData_duration_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXOutputData_results_set")]
  public static extern void TDXOutputData_results_set(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXOutputData_results_get")]
  public static extern global::System.IntPtr TDXOutputData_results_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_new_TDXOutputData")]
  public static extern global::System.IntPtr new_TDXOutputData();

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_delete_TDXOutputData")]
  public static extern void delete_TDXOutputData(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXData_input_data_set")]
  public static extern void TDXData_input_data_set(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXData_input_data_get")]
  public static extern global::System.IntPtr TDXData_input_data_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXData_output_data_set")]
  public static extern void TDXData_output_data_set(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_TDXData_output_data_get")]
  public static extern global::System.IntPtr TDXData_output_data_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_new_TDXData")]
  public static extern global::System.IntPtr new_TDXData();

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_delete_TDXData")]
  public static extern void delete_TDXData(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_tdxInit")]
  public static extern void tdxInit();

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_tdxDestroy")]
  public static extern void tdxDestroy();

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_tdxIsStandalone")]
  public static extern bool tdxIsStandalone();

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_tdxGetInput")]
  public static extern global::System.IntPtr tdxGetInput();

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_tdxSetDuration")]
  public static extern void tdxSetDuration(int jarg1);

  [global::System.Runtime.InteropServices.DllImport("tdxapi_cs", EntryPoint="CSharp_tdxAddResult")]
  public static extern bool tdxAddResult(global::System.Runtime.InteropServices.HandleRef jarg1);
}

}
