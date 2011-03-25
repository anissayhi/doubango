/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class ActionConfig : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ActionConfig(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ActionConfig obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ActionConfig() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tinyWRAPPINVOKE.delete_ActionConfig(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public ActionConfig() : this(tinyWRAPPINVOKE.new_ActionConfig(), true) {
  }

  public bool addHeader(string name, string value) {
    bool ret = tinyWRAPPINVOKE.ActionConfig_addHeader(swigCPtr, name, value);
    return ret;
  }

  public ActionConfig setResponseLine(short code, string phrase) {
    IntPtr cPtr = tinyWRAPPINVOKE.ActionConfig_setResponseLine(swigCPtr, code, phrase);
    ActionConfig ret = (cPtr == IntPtr.Zero) ? null : new ActionConfig(cPtr, false);
    return ret;
  }

  public ActionConfig setMediaString(twrap_media_type_t type, string key, string value) {
    IntPtr cPtr = tinyWRAPPINVOKE.ActionConfig_setMediaString(swigCPtr, (int)type, key, value);
    ActionConfig ret = (cPtr == IntPtr.Zero) ? null : new ActionConfig(cPtr, false);
    return ret;
  }

  public ActionConfig setMediaInt(twrap_media_type_t type, string key, int value) {
    IntPtr cPtr = tinyWRAPPINVOKE.ActionConfig_setMediaInt(swigCPtr, (int)type, key, value);
    ActionConfig ret = (cPtr == IntPtr.Zero) ? null : new ActionConfig(cPtr, false);
    return ret;
  }

}

}
