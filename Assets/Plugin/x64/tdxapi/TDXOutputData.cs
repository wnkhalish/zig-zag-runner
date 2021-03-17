/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace cr2 {

public class TDXOutputData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TDXOutputData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TDXOutputData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TDXOutputData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tdxapiPINVOKE.delete_TDXOutputData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int reps_completed {
    set {
      tdxapiPINVOKE.TDXOutputData_reps_completed_set(swigCPtr, value);
    } 
    get {
      int ret = tdxapiPINVOKE.TDXOutputData_reps_completed_get(swigCPtr);
      return ret;
    } 
  }

  public int duration {
    set {
      tdxapiPINVOKE.TDXOutputData_duration_set(swigCPtr, value);
    } 
    get {
      int ret = tdxapiPINVOKE.TDXOutputData_duration_get(swigCPtr);
      return ret;
    } 
  }

  public TDXResult results {
    set {
      tdxapiPINVOKE.TDXOutputData_results_set(swigCPtr, TDXResult.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = tdxapiPINVOKE.TDXOutputData_results_get(swigCPtr);
      TDXResult ret = (cPtr == global::System.IntPtr.Zero) ? null : new TDXResult(cPtr, false);
      return ret;
    } 
  }

  public TDXOutputData() : this(tdxapiPINVOKE.new_TDXOutputData(), true) {
  }

}

}
