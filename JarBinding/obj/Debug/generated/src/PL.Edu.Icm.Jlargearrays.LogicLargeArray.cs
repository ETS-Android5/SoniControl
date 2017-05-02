using System;
using System.Collections.Generic;
using Android.Runtime;

namespace PL.Edu.Icm.Jlargearrays {

	// Metadata.xml XPath class reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']"
	[global::Android.Runtime.Register ("pl/edu/icm/jlargearrays/LogicLargeArray", DoNotGenerateAcw=true)]
	public partial class LogicLargeArray : global::PL.Edu.Icm.Jlargearrays.LargeArray {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("pl/edu/icm/jlargearrays/LogicLargeArray", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LogicLargeArray); }
		}

		protected LogicLargeArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/constructor[@name='LogicLargeArray' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register (".ctor", "([Z)V", "")]
		public unsafe LogicLargeArray (bool[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (LogicLargeArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Z)V", __args);
					return;
				}

				if (id_ctor_arrayZ == IntPtr.Zero)
					id_ctor_arrayZ = JNIEnv.GetMethodID (class_ref, "<init>", "([Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayZ, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/constructor[@name='LogicLargeArray' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe LogicLargeArray (byte[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (LogicLargeArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_JB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/constructor[@name='LogicLargeArray' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='byte']]"
		[Register (".ctor", "(JB)V", "")]
		public unsafe LogicLargeArray (long p0, sbyte p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (LogicLargeArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(JB)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JB)V", __args);
					return;
				}

				if (id_ctor_JB == IntPtr.Zero)
					id_ctor_JB = JNIEnv.GetMethodID (class_ref, "<init>", "(JB)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JB, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/constructor[@name='LogicLargeArray' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		public unsafe LogicLargeArray (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (LogicLargeArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(JZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JZ)V", __args);
					return;
				}

				if (id_ctor_JZ == IntPtr.Zero)
					id_ctor_JZ = JNIEnv.GetMethodID (class_ref, "<init>", "(JZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JZ, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/constructor[@name='LogicLargeArray' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe LogicLargeArray (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (LogicLargeArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static Delegate cb_and_Lpl_edu_icm_jlargearrays_LogicLargeArray_;
#pragma warning disable 0169
		static Delegate GetAnd_Lpl_edu_icm_jlargearrays_LogicLargeArray_Handler ()
		{
			if (cb_and_Lpl_edu_icm_jlargearrays_LogicLargeArray_ == null)
				cb_and_Lpl_edu_icm_jlargearrays_LogicLargeArray_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_And_Lpl_edu_icm_jlargearrays_LogicLargeArray_);
			return cb_and_Lpl_edu_icm_jlargearrays_LogicLargeArray_;
		}

		static IntPtr n_And_Lpl_edu_icm_jlargearrays_LogicLargeArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::PL.Edu.Icm.Jlargearrays.LogicLargeArray __this = global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.LogicLargeArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::PL.Edu.Icm.Jlargearrays.LogicLargeArray p0 = global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.LogicLargeArray> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.And (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_and_Lpl_edu_icm_jlargearrays_LogicLargeArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='and' and count(parameter)=1 and parameter[1][@type='pl.edu.icm.jlargearrays.LogicLargeArray']]"
		[Register ("and", "(Lpl/edu/icm/jlargearrays/LogicLargeArray;)Lpl/edu/icm/jlargearrays/LogicLargeArray;", "GetAnd_Lpl_edu_icm_jlargearrays_LogicLargeArray_Handler")]
		public virtual unsafe global::PL.Edu.Icm.Jlargearrays.LogicLargeArray And (global::PL.Edu.Icm.Jlargearrays.LogicLargeArray p0)
		{
			if (id_and_Lpl_edu_icm_jlargearrays_LogicLargeArray_ == IntPtr.Zero)
				id_and_Lpl_edu_icm_jlargearrays_LogicLargeArray_ = JNIEnv.GetMethodID (class_ref, "and", "(Lpl/edu/icm/jlargearrays/LogicLargeArray;)Lpl/edu/icm/jlargearrays/LogicLargeArray;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::PL.Edu.Icm.Jlargearrays.LogicLargeArray __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.LogicLargeArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_and_Lpl_edu_icm_jlargearrays_LogicLargeArray_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.LogicLargeArray> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "and", "(Lpl/edu/icm/jlargearrays/LogicLargeArray;)Lpl/edu/icm/jlargearrays/LogicLargeArray;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_get_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='get' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("get", "(J)Ljava/lang/Byte;", "")]
		public unsafe global::Java.Lang.Byte Get (long p0)
		{
			if (id_get_J == IntPtr.Zero)
				id_get_J = JNIEnv.GetMethodID (class_ref, "get", "(J)Ljava/lang/Byte;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Byte> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getBoolean_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getBoolean' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getBoolean", "(J)Z", "")]
		public override sealed unsafe bool GetBoolean (long p0)
		{
			if (id_getBoolean_J == IntPtr.Zero)
				id_getBoolean_J = JNIEnv.GetMethodID (class_ref, "getBoolean", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getBoolean_J, __args);
			} finally {
			}
		}

		static IntPtr id_getBooleanData;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getBooleanData' and count(parameter)=0]"
		[Register ("getBooleanData", "()[Z", "")]
		public override sealed unsafe bool[] GetBooleanData ()
		{
			if (id_getBooleanData == IntPtr.Zero)
				id_getBooleanData = JNIEnv.GetMethodID (class_ref, "getBooleanData", "()[Z");
			try {
				return (bool[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBooleanData), JniHandleOwnership.TransferLocalRef, typeof (bool));
			} finally {
			}
		}

		static IntPtr id_getBooleanData_arrayZJJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getBooleanData' and count(parameter)=4 and parameter[1][@type='boolean[]'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("getBooleanData", "([ZJJJ)[Z", "")]
		public override sealed unsafe bool[] GetBooleanData (bool[] p0, long p1, long p2, long p3)
		{
			if (id_getBooleanData_arrayZJJJ == IntPtr.Zero)
				id_getBooleanData_arrayZJJJ = JNIEnv.GetMethodID (class_ref, "getBooleanData", "([ZJJJ)[Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBooleanData_arrayZJJJ, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getByte_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getByte' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getByte", "(J)B", "")]
		public override sealed unsafe sbyte GetByte (long p0)
		{
			if (id_getByte_J == IntPtr.Zero)
				id_getByte_J = JNIEnv.GetMethodID (class_ref, "getByte", "(J)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getByte_J, __args);
			} finally {
			}
		}

		static IntPtr id_getByteData;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getByteData' and count(parameter)=0]"
		[Register ("getByteData", "()[B", "")]
		public override sealed unsafe byte[] GetByteData ()
		{
			if (id_getByteData == IntPtr.Zero)
				id_getByteData = JNIEnv.GetMethodID (class_ref, "getByteData", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getByteData), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_getByteData_arrayBJJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getByteData' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("getByteData", "([BJJJ)[B", "")]
		public override sealed unsafe byte[] GetByteData (byte[] p0, long p1, long p2, long p3)
		{
			if (id_getByteData_arrayBJJJ == IntPtr.Zero)
				id_getByteData_arrayBJJJ = JNIEnv.GetMethodID (class_ref, "getByteData", "([BJJJ)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getByteData_arrayBJJJ, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getData;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()[B", "")]
		public unsafe byte[] GetData ()
		{
			if (id_getData == IntPtr.Zero)
				id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_getDouble_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getDouble' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getDouble", "(J)D", "")]
		public override sealed unsafe double GetDouble (long p0)
		{
			if (id_getDouble_J == IntPtr.Zero)
				id_getDouble_J = JNIEnv.GetMethodID (class_ref, "getDouble", "(J)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getDouble_J, __args);
			} finally {
			}
		}

		static IntPtr id_getDoubleData;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getDoubleData' and count(parameter)=0]"
		[Register ("getDoubleData", "()[D", "")]
		public override sealed unsafe double[] GetDoubleData ()
		{
			if (id_getDoubleData == IntPtr.Zero)
				id_getDoubleData = JNIEnv.GetMethodID (class_ref, "getDoubleData", "()[D");
			try {
				return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDoubleData), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static IntPtr id_getDoubleData_arrayDJJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getDoubleData' and count(parameter)=4 and parameter[1][@type='double[]'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("getDoubleData", "([DJJJ)[D", "")]
		public override sealed unsafe double[] GetDoubleData (double[] p0, long p1, long p2, long p3)
		{
			if (id_getDoubleData_arrayDJJJ == IntPtr.Zero)
				id_getDoubleData_arrayDJJJ = JNIEnv.GetMethodID (class_ref, "getDoubleData", "([DJJJ)[D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDoubleData_arrayDJJJ, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getFloat_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getFloat' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getFloat", "(J)F", "")]
		public override sealed unsafe float GetFloat (long p0)
		{
			if (id_getFloat_J == IntPtr.Zero)
				id_getFloat_J = JNIEnv.GetMethodID (class_ref, "getFloat", "(J)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getFloat_J, __args);
			} finally {
			}
		}

		static IntPtr id_getFloatData;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getFloatData' and count(parameter)=0]"
		[Register ("getFloatData", "()[F", "")]
		public override sealed unsafe float[] GetFloatData ()
		{
			if (id_getFloatData == IntPtr.Zero)
				id_getFloatData = JNIEnv.GetMethodID (class_ref, "getFloatData", "()[F");
			try {
				return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFloatData), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static IntPtr id_getFloatData_arrayFJJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getFloatData' and count(parameter)=4 and parameter[1][@type='float[]'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("getFloatData", "([FJJJ)[F", "")]
		public override sealed unsafe float[] GetFloatData (float[] p0, long p1, long p2, long p3)
		{
			if (id_getFloatData_arrayFJJJ == IntPtr.Zero)
				id_getFloatData_arrayFJJJ = JNIEnv.GetMethodID (class_ref, "getFloatData", "([FJJJ)[F");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFloatData_arrayFJJJ, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getFromNative_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getFromNative' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getFromNative", "(J)Ljava/lang/Byte;", "")]
		public unsafe global::Java.Lang.Byte GetFromNative (long p0)
		{
			if (id_getFromNative_J == IntPtr.Zero)
				id_getFromNative_J = JNIEnv.GetMethodID (class_ref, "getFromNative", "(J)Ljava/lang/Byte;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Byte> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFromNative_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getInt_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getInt' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getInt", "(J)I", "")]
		public override sealed unsafe int GetInt (long p0)
		{
			if (id_getInt_J == IntPtr.Zero)
				id_getInt_J = JNIEnv.GetMethodID (class_ref, "getInt", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInt_J, __args);
			} finally {
			}
		}

		static IntPtr id_getIntData;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getIntData' and count(parameter)=0]"
		[Register ("getIntData", "()[I", "")]
		public override sealed unsafe int[] GetIntData ()
		{
			if (id_getIntData == IntPtr.Zero)
				id_getIntData = JNIEnv.GetMethodID (class_ref, "getIntData", "()[I");
			try {
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIntData), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_getIntData_arrayIJJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getIntData' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("getIntData", "([IJJJ)[I", "")]
		public override sealed unsafe int[] GetIntData (int[] p0, long p1, long p2, long p3)
		{
			if (id_getIntData_arrayIJJJ == IntPtr.Zero)
				id_getIntData_arrayIJJJ = JNIEnv.GetMethodID (class_ref, "getIntData", "([IJJJ)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIntData_arrayIJJJ, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getLong_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getLong' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getLong", "(J)J", "")]
		public override sealed unsafe long GetLong (long p0)
		{
			if (id_getLong_J == IntPtr.Zero)
				id_getLong_J = JNIEnv.GetMethodID (class_ref, "getLong", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLong_J, __args);
			} finally {
			}
		}

		static IntPtr id_getLongData;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getLongData' and count(parameter)=0]"
		[Register ("getLongData", "()[J", "")]
		public override sealed unsafe long[] GetLongData ()
		{
			if (id_getLongData == IntPtr.Zero)
				id_getLongData = JNIEnv.GetMethodID (class_ref, "getLongData", "()[J");
			try {
				return (long[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLongData), JniHandleOwnership.TransferLocalRef, typeof (long));
			} finally {
			}
		}

		static IntPtr id_getLongData_arrayJJJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getLongData' and count(parameter)=4 and parameter[1][@type='long[]'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("getLongData", "([JJJJ)[J", "")]
		public override sealed unsafe long[] GetLongData (long[] p0, long p1, long p2, long p3)
		{
			if (id_getLongData_arrayJJJJ == IntPtr.Zero)
				id_getLongData_arrayJJJJ = JNIEnv.GetMethodID (class_ref, "getLongData", "([JJJJ)[J");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLongData_arrayJJJJ, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getShort_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getShort' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getShort", "(J)S", "")]
		public override sealed unsafe short GetShort (long p0)
		{
			if (id_getShort_J == IntPtr.Zero)
				id_getShort_J = JNIEnv.GetMethodID (class_ref, "getShort", "(J)S");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getShort_J, __args);
			} finally {
			}
		}

		static IntPtr id_getShortData;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getShortData' and count(parameter)=0]"
		[Register ("getShortData", "()[S", "")]
		public override sealed unsafe short[] GetShortData ()
		{
			if (id_getShortData == IntPtr.Zero)
				id_getShortData = JNIEnv.GetMethodID (class_ref, "getShortData", "()[S");
			try {
				return (short[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShortData), JniHandleOwnership.TransferLocalRef, typeof (short));
			} finally {
			}
		}

		static IntPtr id_getShortData_arraySJJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getShortData' and count(parameter)=4 and parameter[1][@type='short[]'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("getShortData", "([SJJJ)[S", "")]
		public override sealed unsafe short[] GetShortData (short[] p0, long p1, long p2, long p3)
		{
			if (id_getShortData_arraySJJJ == IntPtr.Zero)
				id_getShortData_arraySJJJ = JNIEnv.GetMethodID (class_ref, "getShortData", "([SJJJ)[S");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShortData_arraySJJJ, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getUnsignedByte_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='getUnsignedByte' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getUnsignedByte", "(J)S", "")]
		public override sealed unsafe short GetUnsignedByte (long p0)
		{
			if (id_getUnsignedByte_J == IntPtr.Zero)
				id_getUnsignedByte_J = JNIEnv.GetMethodID (class_ref, "getUnsignedByte", "(J)S");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getUnsignedByte_J, __args);
			} finally {
			}
		}

		static Delegate cb_not;
#pragma warning disable 0169
		static Delegate GetNotHandler ()
		{
			if (cb_not == null)
				cb_not = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Not);
			return cb_not;
		}

		static IntPtr n_Not (IntPtr jnienv, IntPtr native__this)
		{
			global::PL.Edu.Icm.Jlargearrays.LogicLargeArray __this = global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.LogicLargeArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Not ());
		}
#pragma warning restore 0169

		static IntPtr id_not;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='not' and count(parameter)=0]"
		[Register ("not", "()Lpl/edu/icm/jlargearrays/LogicLargeArray;", "GetNotHandler")]
		public virtual unsafe global::PL.Edu.Icm.Jlargearrays.LogicLargeArray Not ()
		{
			if (id_not == IntPtr.Zero)
				id_not = JNIEnv.GetMethodID (class_ref, "not", "()Lpl/edu/icm/jlargearrays/LogicLargeArray;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.LogicLargeArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_not), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.LogicLargeArray> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "not", "()Lpl/edu/icm/jlargearrays/LogicLargeArray;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_or_Lpl_edu_icm_jlargearrays_LogicLargeArray_;
#pragma warning disable 0169
		static Delegate GetOr_Lpl_edu_icm_jlargearrays_LogicLargeArray_Handler ()
		{
			if (cb_or_Lpl_edu_icm_jlargearrays_LogicLargeArray_ == null)
				cb_or_Lpl_edu_icm_jlargearrays_LogicLargeArray_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Or_Lpl_edu_icm_jlargearrays_LogicLargeArray_);
			return cb_or_Lpl_edu_icm_jlargearrays_LogicLargeArray_;
		}

		static IntPtr n_Or_Lpl_edu_icm_jlargearrays_LogicLargeArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::PL.Edu.Icm.Jlargearrays.LogicLargeArray __this = global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.LogicLargeArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::PL.Edu.Icm.Jlargearrays.LogicLargeArray p0 = global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.LogicLargeArray> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Or (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_or_Lpl_edu_icm_jlargearrays_LogicLargeArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='or' and count(parameter)=1 and parameter[1][@type='pl.edu.icm.jlargearrays.LogicLargeArray']]"
		[Register ("or", "(Lpl/edu/icm/jlargearrays/LogicLargeArray;)Lpl/edu/icm/jlargearrays/LogicLargeArray;", "GetOr_Lpl_edu_icm_jlargearrays_LogicLargeArray_Handler")]
		public virtual unsafe global::PL.Edu.Icm.Jlargearrays.LogicLargeArray Or (global::PL.Edu.Icm.Jlargearrays.LogicLargeArray p0)
		{
			if (id_or_Lpl_edu_icm_jlargearrays_LogicLargeArray_ == IntPtr.Zero)
				id_or_Lpl_edu_icm_jlargearrays_LogicLargeArray_ = JNIEnv.GetMethodID (class_ref, "or", "(Lpl/edu/icm/jlargearrays/LogicLargeArray;)Lpl/edu/icm/jlargearrays/LogicLargeArray;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::PL.Edu.Icm.Jlargearrays.LogicLargeArray __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.LogicLargeArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_or_Lpl_edu_icm_jlargearrays_LogicLargeArray_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.LogicLargeArray> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "or", "(Lpl/edu/icm/jlargearrays/LogicLargeArray;)Lpl/edu/icm/jlargearrays/LogicLargeArray;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setBoolean_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='setBoolean' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("setBoolean", "(JZ)V", "")]
		public override sealed unsafe void SetBoolean (long p0, bool p1)
		{
			if (id_setBoolean_JZ == IntPtr.Zero)
				id_setBoolean_JZ = JNIEnv.GetMethodID (class_ref, "setBoolean", "(JZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBoolean_JZ, __args);
			} finally {
			}
		}

		static IntPtr id_setByte_JB;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='setByte' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='byte']]"
		[Register ("setByte", "(JB)V", "")]
		public override sealed unsafe void SetByte (long p0, sbyte p1)
		{
			if (id_setByte_JB == IntPtr.Zero)
				id_setByte_JB = JNIEnv.GetMethodID (class_ref, "setByte", "(JB)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setByte_JB, __args);
			} finally {
			}
		}

		static IntPtr id_setDouble_JD;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='setDouble' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='double']]"
		[Register ("setDouble", "(JD)V", "")]
		public override sealed unsafe void SetDouble (long p0, double p1)
		{
			if (id_setDouble_JD == IntPtr.Zero)
				id_setDouble_JD = JNIEnv.GetMethodID (class_ref, "setDouble", "(JD)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDouble_JD, __args);
			} finally {
			}
		}

		static IntPtr id_setFloat_JF;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='setFloat' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='float']]"
		[Register ("setFloat", "(JF)V", "")]
		public override sealed unsafe void SetFloat (long p0, float p1)
		{
			if (id_setFloat_JF == IntPtr.Zero)
				id_setFloat_JF = JNIEnv.GetMethodID (class_ref, "setFloat", "(JF)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFloat_JF, __args);
			} finally {
			}
		}

		static IntPtr id_setInt_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='setInt' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("setInt", "(JI)V", "")]
		public override sealed unsafe void SetInt (long p0, int p1)
		{
			if (id_setInt_JI == IntPtr.Zero)
				id_setInt_JI = JNIEnv.GetMethodID (class_ref, "setInt", "(JI)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInt_JI, __args);
			} finally {
			}
		}

		static IntPtr id_setLong_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='setLong' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("setLong", "(JJ)V", "")]
		public override sealed unsafe void SetLong (long p0, long p1)
		{
			if (id_setLong_JJ == IntPtr.Zero)
				id_setLong_JJ = JNIEnv.GetMethodID (class_ref, "setLong", "(JJ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLong_JJ, __args);
			} finally {
			}
		}

		static IntPtr id_setShort_JS;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='setShort' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='short']]"
		[Register ("setShort", "(JS)V", "")]
		public override sealed unsafe void SetShort (long p0, short p1)
		{
			if (id_setShort_JS == IntPtr.Zero)
				id_setShort_JS = JNIEnv.GetMethodID (class_ref, "setShort", "(JS)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShort_JS, __args);
			} finally {
			}
		}

		static IntPtr id_setToNative_JLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='setToNative' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setToNative", "(JLjava/lang/Object;)V", "")]
		public override sealed unsafe void SetToNative (long p0, global::Java.Lang.Object p1)
		{
			if (id_setToNative_JLjava_lang_Object_ == IntPtr.Zero)
				id_setToNative_JLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setToNative", "(JLjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setToNative_JLjava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_setUnsignedByte_JS;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='setUnsignedByte' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='short']]"
		[Register ("setUnsignedByte", "(JS)V", "")]
		public override sealed unsafe void SetUnsignedByte (long p0, short p1)
		{
			if (id_setUnsignedByte_JS == IntPtr.Zero)
				id_setUnsignedByte_JS = JNIEnv.GetMethodID (class_ref, "setUnsignedByte", "(JS)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUnsignedByte_JS, __args);
			} finally {
			}
		}

		static Delegate cb_xor_Lpl_edu_icm_jlargearrays_LogicLargeArray_;
#pragma warning disable 0169
		static Delegate GetXor_Lpl_edu_icm_jlargearrays_LogicLargeArray_Handler ()
		{
			if (cb_xor_Lpl_edu_icm_jlargearrays_LogicLargeArray_ == null)
				cb_xor_Lpl_edu_icm_jlargearrays_LogicLargeArray_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Xor_Lpl_edu_icm_jlargearrays_LogicLargeArray_);
			return cb_xor_Lpl_edu_icm_jlargearrays_LogicLargeArray_;
		}

		static IntPtr n_Xor_Lpl_edu_icm_jlargearrays_LogicLargeArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::PL.Edu.Icm.Jlargearrays.LogicLargeArray __this = global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.LogicLargeArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::PL.Edu.Icm.Jlargearrays.LogicLargeArray p0 = global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.LogicLargeArray> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Xor (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_xor_Lpl_edu_icm_jlargearrays_LogicLargeArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='LogicLargeArray']/method[@name='xor' and count(parameter)=1 and parameter[1][@type='pl.edu.icm.jlargearrays.LogicLargeArray']]"
		[Register ("xor", "(Lpl/edu/icm/jlargearrays/LogicLargeArray;)Lpl/edu/icm/jlargearrays/LogicLargeArray;", "GetXor_Lpl_edu_icm_jlargearrays_LogicLargeArray_Handler")]
		public virtual unsafe global::PL.Edu.Icm.Jlargearrays.LogicLargeArray Xor (global::PL.Edu.Icm.Jlargearrays.LogicLargeArray p0)
		{
			if (id_xor_Lpl_edu_icm_jlargearrays_LogicLargeArray_ == IntPtr.Zero)
				id_xor_Lpl_edu_icm_jlargearrays_LogicLargeArray_ = JNIEnv.GetMethodID (class_ref, "xor", "(Lpl/edu/icm/jlargearrays/LogicLargeArray;)Lpl/edu/icm/jlargearrays/LogicLargeArray;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::PL.Edu.Icm.Jlargearrays.LogicLargeArray __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.LogicLargeArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_xor_Lpl_edu_icm_jlargearrays_LogicLargeArray_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.LogicLargeArray> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "xor", "(Lpl/edu/icm/jlargearrays/LogicLargeArray;)Lpl/edu/icm/jlargearrays/LogicLargeArray;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
