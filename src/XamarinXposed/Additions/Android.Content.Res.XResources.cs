using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.Content.Res {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.content.res']/class[@name='XResources']"
	[global::Android.Runtime.Register ("android/content/res/XResources", DoNotGenerateAcw=true)]
	public partial class XResources : global::Android.Content.Res.Resources {

		// Metadata.xml XPath class reference: path="/api/package[@name='android.content.res']/class[@name='XResources.DimensionReplacement']"
		[global::Android.Runtime.Register ("android/content/res/XResources$DimensionReplacement", DoNotGenerateAcw=true)]
		public partial class DimensionReplacement : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("android/content/res/XResources$DimensionReplacement", typeof (DimensionReplacement));
			internal static new IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected DimensionReplacement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.content.res']/class[@name='XResources.DimensionReplacement']/constructor[@name='XResources.DimensionReplacement' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='int']]"
			[Register (".ctor", "(FI)V", "")]
			public unsafe DimensionReplacement (float value, int unit)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(FI)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (value);
					__args [1] = new JniArgumentValue (unit);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_getDimension_Landroid_util_DisplayMetrics_;
#pragma warning disable 0169
			static Delegate GetGetDimension_Landroid_util_DisplayMetrics_Handler ()
			{
				if (cb_getDimension_Landroid_util_DisplayMetrics_ == null)
					cb_getDimension_Landroid_util_DisplayMetrics_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float>) n_GetDimension_Landroid_util_DisplayMetrics_);
				return cb_getDimension_Landroid_util_DisplayMetrics_;
			}

			static float n_GetDimension_Landroid_util_DisplayMetrics_ (IntPtr jnienv, IntPtr native__this, IntPtr native_metrics)
			{
				global::Android.Content.Res.XResources.DimensionReplacement __this = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResources.DimensionReplacement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Util.DisplayMetrics metrics = global::Java.Lang.Object.GetObject<global::Android.Util.DisplayMetrics> (native_metrics, JniHandleOwnership.DoNotTransfer);
				float __ret = __this.GetDimension (metrics);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources.DimensionReplacement']/method[@name='getDimension' and count(parameter)=1 and parameter[1][@type='android.util.DisplayMetrics']]"
			[Register ("getDimension", "(Landroid/util/DisplayMetrics;)F", "GetGetDimension_Landroid_util_DisplayMetrics_Handler")]
			public virtual unsafe float GetDimension (global::Android.Util.DisplayMetrics metrics)
			{
				const string __id = "getDimension.(Landroid/util/DisplayMetrics;)F";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((metrics == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metrics).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_getDimensionPixelOffset_Landroid_util_DisplayMetrics_;
#pragma warning disable 0169
			static Delegate GetGetDimensionPixelOffset_Landroid_util_DisplayMetrics_Handler ()
			{
				if (cb_getDimensionPixelOffset_Landroid_util_DisplayMetrics_ == null)
					cb_getDimensionPixelOffset_Landroid_util_DisplayMetrics_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetDimensionPixelOffset_Landroid_util_DisplayMetrics_);
				return cb_getDimensionPixelOffset_Landroid_util_DisplayMetrics_;
			}

			static int n_GetDimensionPixelOffset_Landroid_util_DisplayMetrics_ (IntPtr jnienv, IntPtr native__this, IntPtr native_metrics)
			{
				global::Android.Content.Res.XResources.DimensionReplacement __this = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResources.DimensionReplacement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Util.DisplayMetrics metrics = global::Java.Lang.Object.GetObject<global::Android.Util.DisplayMetrics> (native_metrics, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetDimensionPixelOffset (metrics);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources.DimensionReplacement']/method[@name='getDimensionPixelOffset' and count(parameter)=1 and parameter[1][@type='android.util.DisplayMetrics']]"
			[Register ("getDimensionPixelOffset", "(Landroid/util/DisplayMetrics;)I", "GetGetDimensionPixelOffset_Landroid_util_DisplayMetrics_Handler")]
			public virtual unsafe int GetDimensionPixelOffset (global::Android.Util.DisplayMetrics metrics)
			{
				const string __id = "getDimensionPixelOffset.(Landroid/util/DisplayMetrics;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((metrics == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metrics).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_getDimensionPixelSize_Landroid_util_DisplayMetrics_;
#pragma warning disable 0169
			static Delegate GetGetDimensionPixelSize_Landroid_util_DisplayMetrics_Handler ()
			{
				if (cb_getDimensionPixelSize_Landroid_util_DisplayMetrics_ == null)
					cb_getDimensionPixelSize_Landroid_util_DisplayMetrics_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetDimensionPixelSize_Landroid_util_DisplayMetrics_);
				return cb_getDimensionPixelSize_Landroid_util_DisplayMetrics_;
			}

			static int n_GetDimensionPixelSize_Landroid_util_DisplayMetrics_ (IntPtr jnienv, IntPtr native__this, IntPtr native_metrics)
			{
				global::Android.Content.Res.XResources.DimensionReplacement __this = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResources.DimensionReplacement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Util.DisplayMetrics metrics = global::Java.Lang.Object.GetObject<global::Android.Util.DisplayMetrics> (native_metrics, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetDimensionPixelSize (metrics);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources.DimensionReplacement']/method[@name='getDimensionPixelSize' and count(parameter)=1 and parameter[1][@type='android.util.DisplayMetrics']]"
			[Register ("getDimensionPixelSize", "(Landroid/util/DisplayMetrics;)I", "GetGetDimensionPixelSize_Landroid_util_DisplayMetrics_Handler")]
			public virtual unsafe int GetDimensionPixelSize (global::Android.Util.DisplayMetrics metrics)
			{
				const string __id = "getDimensionPixelSize.(Landroid/util/DisplayMetrics;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((metrics == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metrics).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.content.res']/class[@name='XResources.DrawableLoader']"
		[global::Android.Runtime.Register ("android/content/res/XResources$DrawableLoader", DoNotGenerateAcw=true)]
		public abstract partial class DrawableLoader : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("android/content/res/XResources$DrawableLoader", typeof (DrawableLoader));
			internal static new IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected DrawableLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.content.res']/class[@name='XResources.DrawableLoader']/constructor[@name='XResources.DrawableLoader' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DrawableLoader ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_newDrawable_Landroid_content_res_XResources_I;
#pragma warning disable 0169
			static Delegate GetNewDrawable_Landroid_content_res_XResources_IHandler ()
			{
				if (cb_newDrawable_Landroid_content_res_XResources_I == null)
					cb_newDrawable_Landroid_content_res_XResources_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_NewDrawable_Landroid_content_res_XResources_I);
				return cb_newDrawable_Landroid_content_res_XResources_I;
			}

			static IntPtr n_NewDrawable_Landroid_content_res_XResources_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Android.Content.Res.XResources.DrawableLoader __this = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResources.DrawableLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Res.XResources p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResources> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewDrawable (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources.DrawableLoader']/method[@name='newDrawable' and count(parameter)=2 and parameter[1][@type='android.content.res.XResources'] and parameter[2][@type='int']]"
			[Register ("newDrawable", "(Landroid/content/res/XResources;I)Landroid/graphics/drawable/Drawable;", "GetNewDrawable_Landroid_content_res_XResources_IHandler")]
			public abstract global::Android.Graphics.Drawables.Drawable NewDrawable (global::Android.Content.Res.XResources p0, int p1);

			static Delegate cb_newDrawableForDensity_Landroid_content_res_XResources_II;
#pragma warning disable 0169
			static Delegate GetNewDrawableForDensity_Landroid_content_res_XResources_IIHandler ()
			{
				if (cb_newDrawableForDensity_Landroid_content_res_XResources_II == null)
					cb_newDrawableForDensity_Landroid_content_res_XResources_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_NewDrawableForDensity_Landroid_content_res_XResources_II);
				return cb_newDrawableForDensity_Landroid_content_res_XResources_II;
			}

			static IntPtr n_NewDrawableForDensity_Landroid_content_res_XResources_II (IntPtr jnienv, IntPtr native__this, IntPtr native_res, int id, int density)
			{
				global::Android.Content.Res.XResources.DrawableLoader __this = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResources.DrawableLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Res.XResources res = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResources> (native_res, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewDrawableForDensity (res, id, density));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources.DrawableLoader']/method[@name='newDrawableForDensity' and count(parameter)=3 and parameter[1][@type='android.content.res.XResources'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("newDrawableForDensity", "(Landroid/content/res/XResources;II)Landroid/graphics/drawable/Drawable;", "GetNewDrawableForDensity_Landroid_content_res_XResources_IIHandler")]
			public virtual unsafe global::Android.Graphics.Drawables.Drawable NewDrawableForDensity (global::Android.Content.Res.XResources res, int id, int density)
			{
				const string __id = "newDrawableForDensity.(Landroid/content/res/XResources;II)Landroid/graphics/drawable/Drawable;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((res == null) ? IntPtr.Zero : ((global::Java.Lang.Object) res).Handle);
					__args [1] = new JniArgumentValue (id);
					__args [2] = new JniArgumentValue (density);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("android/content/res/XResources$DrawableLoader", DoNotGenerateAcw=true)]
		internal partial class DrawableLoaderInvoker : DrawableLoader {

			public DrawableLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("android/content/res/XResources$DrawableLoader", typeof (DrawableLoaderInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources.DrawableLoader']/method[@name='newDrawable' and count(parameter)=2 and parameter[1][@type='android.content.res.XResources'] and parameter[2][@type='int']]"
			[Register ("newDrawable", "(Landroid/content/res/XResources;I)Landroid/graphics/drawable/Drawable;", "GetNewDrawable_Landroid_content_res_XResources_IHandler")]
			public override unsafe global::Android.Graphics.Drawables.Drawable NewDrawable (global::Android.Content.Res.XResources p0, int p1)
			{
				const string __id = "newDrawable.(Landroid/content/res/XResources;I)Landroid/graphics/drawable/Drawable;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='android.content.res']/class[@name='XResources.ResourceNames']"
		[global::Android.Runtime.Register ("android/content/res/XResources$ResourceNames", DoNotGenerateAcw=true)]
		public partial class ResourceNames : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='android.content.res']/class[@name='XResources.ResourceNames']/field[@name='fullName']"
			[Register ("fullName")]
			public string FullName {
				get {
					const string __id = "fullName.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "fullName.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='android.content.res']/class[@name='XResources.ResourceNames']/field[@name='id']"
			[Register ("id")]
			public int Id {
				get {
					const string __id = "id.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "id.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='android.content.res']/class[@name='XResources.ResourceNames']/field[@name='name']"
			[Register ("name")]
			public string Name {
				get {
					const string __id = "name.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "name.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='android.content.res']/class[@name='XResources.ResourceNames']/field[@name='pkg']"
			[Register ("pkg")]
			public string Pkg {
				get {
					const string __id = "pkg.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "pkg.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='android.content.res']/class[@name='XResources.ResourceNames']/field[@name='type']"
			[Register ("type")]
			public string Type {
				get {
					const string __id = "type.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "type.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("android/content/res/XResources$ResourceNames", typeof (ResourceNames));
			internal static new IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected ResourceNames (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_equals_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler ()
			{
				if (cb_equals_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I == null)
					cb_equals_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_Equals_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I);
				return cb_equals_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
			}

			static bool n_Equals_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_pkg, IntPtr native_name, IntPtr native_type, int id)
			{
				global::Android.Content.Res.XResources.ResourceNames __this = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResources.ResourceNames> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string pkg = JNIEnv.GetString (native_pkg, JniHandleOwnership.DoNotTransfer);
				string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				string type = JNIEnv.GetString (native_type, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (pkg, name, type, id);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources.ResourceNames']/method[@name='equals' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
			[Register ("equals", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Z", "GetEquals_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler")]
			public new virtual unsafe bool Equals (string pkg, string name, string type, int id)
			{
				const string __id = "equals.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Z";
				IntPtr native_pkg = JNIEnv.NewString (pkg);
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_type = JNIEnv.NewString (type);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_pkg);
					__args [1] = new JniArgumentValue (native_name);
					__args [2] = new JniArgumentValue (native_type);
					__args [3] = new JniArgumentValue (id);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_pkg);
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_type);
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("android/content/res/XResources", typeof (XResources));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected XResources (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getPackageName;
#pragma warning disable 0169
		static Delegate GetGetPackageNameHandler ()
		{
			if (cb_getPackageName == null)
				cb_getPackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageName);
			return cb_getPackageName;
		}

		static IntPtr n_GetPackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Res.XResources __this = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResources> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		public virtual unsafe string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				const string __id = "getPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string PackageNameDuringConstruction {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources']/method[@name='getPackageNameDuringConstruction' and count(parameter)=0]"
			[Register ("getPackageNameDuringConstruction", "()Ljava/lang/String;", "GetGetPackageNameDuringConstructionHandler")]
			get {
				const string __id = "getPackageNameDuringConstruction.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addResource_Landroid_content_res_Resources_I;
#pragma warning disable 0169
		static Delegate GetAddResource_Landroid_content_res_Resources_IHandler ()
		{
			if (cb_addResource_Landroid_content_res_Resources_I == null)
				cb_addResource_Landroid_content_res_Resources_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_AddResource_Landroid_content_res_Resources_I);
			return cb_addResource_Landroid_content_res_Resources_I;
		}

		static int n_AddResource_Landroid_content_res_Resources_I (IntPtr jnienv, IntPtr native__this, IntPtr native_res, int id)
		{
			global::Android.Content.Res.XResources __this = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResources> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Resources res = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources> (native_res, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.AddResource (res, id);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources']/method[@name='addResource' and count(parameter)=2 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='int']]"
		[Register ("addResource", "(Landroid/content/res/Resources;I)I", "GetAddResource_Landroid_content_res_Resources_IHandler")]
		public virtual unsafe int AddResource (global::Android.Content.Res.Resources res, int id)
		{
			const string __id = "addResource.(Landroid/content/res/Resources;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((res == null) ? IntPtr.Zero : ((global::Java.Lang.Object) res).Handle);
				__args [1] = new JniArgumentValue (id);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources']/method[@name='getFakeResId' and count(parameter)=2 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='int']]"
		[Register ("getFakeResId", "(Landroid/content/res/Resources;I)I", "")]
		public static unsafe int GetFakeResId (global::Android.Content.Res.Resources res, int id)
		{
			const string __id = "getFakeResId.(Landroid/content/res/Resources;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((res == null) ? IntPtr.Zero : ((global::Java.Lang.Object) res).Handle);
				__args [1] = new JniArgumentValue (id);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources']/method[@name='getFakeResId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFakeResId", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetFakeResId (string resName)
		{
			const string __id = "getFakeResId.(Ljava/lang/String;)I";
			IntPtr native_resName = JNIEnv.NewString (resName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_resName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_resName);
			}
		}

		static Delegate cb_hookLayout_ILde_robv_android_xposed_callbacks_XC_LayoutInflated_;
#pragma warning disable 0169
		static Delegate GetHookLayout_ILde_robv_android_xposed_callbacks_XC_LayoutInflated_Handler ()
		{
			if (cb_hookLayout_ILde_robv_android_xposed_callbacks_XC_LayoutInflated_ == null)
				cb_hookLayout_ILde_robv_android_xposed_callbacks_XC_LayoutInflated_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_HookLayout_ILde_robv_android_xposed_callbacks_XC_LayoutInflated_);
			return cb_hookLayout_ILde_robv_android_xposed_callbacks_XC_LayoutInflated_;
		}

		static IntPtr n_HookLayout_ILde_robv_android_xposed_callbacks_XC_LayoutInflated_ (IntPtr jnienv, IntPtr native__this, int id, IntPtr native__callback)
		{
			global::Android.Content.Res.XResources __this = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResources> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xposed.Callbacks.XC_LayoutInflated @callback = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_LayoutInflated> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HookLayout (id, @callback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources']/method[@name='hookLayout' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='de.robv.android.xposed.callbacks.XC_LayoutInflated']]"
		[Register ("hookLayout", "(ILde/robv/android/xposed/callbacks/XC_LayoutInflated;)Lde/robv/android/xposed/callbacks/XC_LayoutInflated$Unhook;", "GetHookLayout_ILde_robv_android_xposed_callbacks_XC_LayoutInflated_Handler")]
		public virtual unsafe global::Xposed.Callbacks.XC_LayoutInflated.Unhook HookLayout (int id, global::Xposed.Callbacks.XC_LayoutInflated @callback)
		{
			const string __id = "hookLayout.(ILde/robv/android/xposed/callbacks/XC_LayoutInflated;)Lde/robv/android/xposed/callbacks/XC_LayoutInflated$Unhook;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (id);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_LayoutInflated.Unhook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hookLayout_Ljava_lang_String_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetHookLayout_Ljava_lang_String_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_Handler ()
		{
			if (cb_hookLayout_Ljava_lang_String_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_ == null)
				cb_hookLayout_Ljava_lang_String_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HookLayout_Ljava_lang_String_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_);
			return cb_hookLayout_Ljava_lang_String_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_;
		}

		[Obsolete]
		static IntPtr n_HookLayout_Ljava_lang_String_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fullName, IntPtr native__callback)
		{
			global::Android.Content.Res.XResources __this = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResources> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string fullName = JNIEnv.GetString (native_fullName, JniHandleOwnership.DoNotTransfer);
			global::Xposed.Callbacks.XC_LayoutInflated @callback = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_LayoutInflated> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HookLayout (fullName, @callback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources']/method[@name='hookLayout' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='de.robv.android.xposed.callbacks.XC_LayoutInflated']]"
		[Obsolete (@"deprecated")]
		[Register ("hookLayout", "(Ljava/lang/String;Lde/robv/android/xposed/callbacks/XC_LayoutInflated;)Lde/robv/android/xposed/callbacks/XC_LayoutInflated$Unhook;", "GetHookLayout_Ljava_lang_String_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_Handler")]
		public virtual unsafe global::Xposed.Callbacks.XC_LayoutInflated.Unhook HookLayout (string fullName, global::Xposed.Callbacks.XC_LayoutInflated @callback)
		{
			const string __id = "hookLayout.(Ljava/lang/String;Lde/robv/android/xposed/callbacks/XC_LayoutInflated;)Lde/robv/android/xposed/callbacks/XC_LayoutInflated$Unhook;";
			IntPtr native_fullName = JNIEnv.NewString (fullName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fullName);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_LayoutInflated.Unhook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fullName);
			}
		}

		static Delegate cb_hookLayout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_;
#pragma warning disable 0169
		static Delegate GetHookLayout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_Handler ()
		{
			if (cb_hookLayout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_ == null)
				cb_hookLayout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HookLayout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_);
			return cb_hookLayout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_;
		}

		static IntPtr n_HookLayout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pkg, IntPtr native_type, IntPtr native_name, IntPtr native__callback)
		{
			global::Android.Content.Res.XResources __this = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResources> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string pkg = JNIEnv.GetString (native_pkg, JniHandleOwnership.DoNotTransfer);
			string type = JNIEnv.GetString (native_type, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Xposed.Callbacks.XC_LayoutInflated @callback = global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_LayoutInflated> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HookLayout (pkg, type, name, @callback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources']/method[@name='hookLayout' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='de.robv.android.xposed.callbacks.XC_LayoutInflated']]"
		[Register ("hookLayout", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lde/robv/android/xposed/callbacks/XC_LayoutInflated;)Lde/robv/android/xposed/callbacks/XC_LayoutInflated$Unhook;", "GetHookLayout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lde_robv_android_xposed_callbacks_XC_LayoutInflated_Handler")]
		public virtual unsafe global::Xposed.Callbacks.XC_LayoutInflated.Unhook HookLayout (string pkg, string type, string name, global::Xposed.Callbacks.XC_LayoutInflated @callback)
		{
			const string __id = "hookLayout.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lde/robv/android/xposed/callbacks/XC_LayoutInflated;)Lde/robv/android/xposed/callbacks/XC_LayoutInflated$Unhook;";
			IntPtr native_pkg = JNIEnv.NewString (pkg);
			IntPtr native_type = JNIEnv.NewString (type);
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_pkg);
				__args [1] = new JniArgumentValue (native_type);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_LayoutInflated.Unhook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_pkg);
				JNIEnv.DeleteLocalRef (native_type);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources']/method[@name='hookSystemWideLayout' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='de.robv.android.xposed.callbacks.XC_LayoutInflated']]"
		[Register ("hookSystemWideLayout", "(ILde/robv/android/xposed/callbacks/XC_LayoutInflated;)Lde/robv/android/xposed/callbacks/XC_LayoutInflated$Unhook;", "")]
		public static unsafe global::Xposed.Callbacks.XC_LayoutInflated.Unhook HookSystemWideLayout (int id, global::Xposed.Callbacks.XC_LayoutInflated @callback)
		{
			const string __id = "hookSystemWideLayout.(ILde/robv/android/xposed/callbacks/XC_LayoutInflated;)Lde/robv/android/xposed/callbacks/XC_LayoutInflated$Unhook;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (id);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_LayoutInflated.Unhook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources']/method[@name='hookSystemWideLayout' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='de.robv.android.xposed.callbacks.XC_LayoutInflated']]"
		[Obsolete (@"deprecated")]
		[Register ("hookSystemWideLayout", "(Ljava/lang/String;Lde/robv/android/xposed/callbacks/XC_LayoutInflated;)Lde/robv/android/xposed/callbacks/XC_LayoutInflated$Unhook;", "")]
		public static unsafe global::Xposed.Callbacks.XC_LayoutInflated.Unhook HookSystemWideLayout (string fullName, global::Xposed.Callbacks.XC_LayoutInflated @callback)
		{
			const string __id = "hookSystemWideLayout.(Ljava/lang/String;Lde/robv/android/xposed/callbacks/XC_LayoutInflated;)Lde/robv/android/xposed/callbacks/XC_LayoutInflated$Unhook;";
			IntPtr native_fullName = JNIEnv.NewString (fullName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fullName);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_LayoutInflated.Unhook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fullName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources']/method[@name='hookSystemWideLayout' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='de.robv.android.xposed.callbacks.XC_LayoutInflated']]"
		[Register ("hookSystemWideLayout", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lde/robv/android/xposed/callbacks/XC_LayoutInflated;)Lde/robv/android/xposed/callbacks/XC_LayoutInflated$Unhook;", "")]
		public static unsafe global::Xposed.Callbacks.XC_LayoutInflated.Unhook HookSystemWideLayout (string pkg, string type, string name, global::Xposed.Callbacks.XC_LayoutInflated @callback)
		{
			const string __id = "hookSystemWideLayout.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lde/robv/android/xposed/callbacks/XC_LayoutInflated;)Lde/robv/android/xposed/callbacks/XC_LayoutInflated$Unhook;";
			IntPtr native_pkg = JNIEnv.NewString (pkg);
			IntPtr native_type = JNIEnv.NewString (type);
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_pkg);
				__args [1] = new JniArgumentValue (native_type);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Xposed.Callbacks.XC_LayoutInflated.Unhook> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_pkg);
				JNIEnv.DeleteLocalRef (native_type);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_setReplacement_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetReplacement_ILjava_lang_Object_Handler ()
		{
			if (cb_setReplacement_ILjava_lang_Object_ == null)
				cb_setReplacement_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetReplacement_ILjava_lang_Object_);
			return cb_setReplacement_ILjava_lang_Object_;
		}

		static void n_SetReplacement_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int id, IntPtr native_replacement)
		{
			global::Android.Content.Res.XResources __this = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResources> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object replacement = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_replacement, JniHandleOwnership.DoNotTransfer);
			__this.SetReplacement (id, replacement);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources']/method[@name='setReplacement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setReplacement", "(ILjava/lang/Object;)V", "GetSetReplacement_ILjava_lang_Object_Handler")]
		public virtual unsafe void SetReplacement (int id, global::Java.Lang.Object replacement)
		{
			const string __id = "setReplacement.(ILjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (id);
				__args [1] = new JniArgumentValue ((replacement == null) ? IntPtr.Zero : ((global::Java.Lang.Object) replacement).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setReplacement_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetReplacement_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_setReplacement_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_setReplacement_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetReplacement_Ljava_lang_String_Ljava_lang_Object_);
			return cb_setReplacement_Ljava_lang_String_Ljava_lang_Object_;
		}

		[Obsolete]
		static void n_SetReplacement_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fullName, IntPtr native_replacement)
		{
			global::Android.Content.Res.XResources __this = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResources> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string fullName = JNIEnv.GetString (native_fullName, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object replacement = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_replacement, JniHandleOwnership.DoNotTransfer);
			__this.SetReplacement (fullName, replacement);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources']/method[@name='setReplacement' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Obsolete (@"deprecated")]
		[Register ("setReplacement", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetReplacement_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetReplacement (string fullName, global::Java.Lang.Object replacement)
		{
			const string __id = "setReplacement.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_fullName = JNIEnv.NewString (fullName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fullName);
				__args [1] = new JniArgumentValue ((replacement == null) ? IntPtr.Zero : ((global::Java.Lang.Object) replacement).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fullName);
			}
		}

		static Delegate cb_setReplacement_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetReplacement_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_setReplacement_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_setReplacement_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetReplacement_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_);
			return cb_setReplacement_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_SetReplacement_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pkg, IntPtr native_type, IntPtr native_name, IntPtr native_replacement)
		{
			global::Android.Content.Res.XResources __this = global::Java.Lang.Object.GetObject<global::Android.Content.Res.XResources> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string pkg = JNIEnv.GetString (native_pkg, JniHandleOwnership.DoNotTransfer);
			string type = JNIEnv.GetString (native_type, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object replacement = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_replacement, JniHandleOwnership.DoNotTransfer);
			__this.SetReplacement (pkg, type, name, replacement);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources']/method[@name='setReplacement' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object']]"
		[Register ("setReplacement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", "GetSetReplacement_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetReplacement (string pkg, string type, string name, global::Java.Lang.Object replacement)
		{
			const string __id = "setReplacement.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_pkg = JNIEnv.NewString (pkg);
			IntPtr native_type = JNIEnv.NewString (type);
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_pkg);
				__args [1] = new JniArgumentValue (native_type);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue ((replacement == null) ? IntPtr.Zero : ((global::Java.Lang.Object) replacement).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pkg);
				JNIEnv.DeleteLocalRef (native_type);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources']/method[@name='setSystemWideReplacement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setSystemWideReplacement", "(ILjava/lang/Object;)V", "")]
		public static unsafe void SetSystemWideReplacement (int id, global::Java.Lang.Object replacement)
		{
			const string __id = "setSystemWideReplacement.(ILjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (id);
				__args [1] = new JniArgumentValue ((replacement == null) ? IntPtr.Zero : ((global::Java.Lang.Object) replacement).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources']/method[@name='setSystemWideReplacement' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Obsolete (@"deprecated")]
		[Register ("setSystemWideReplacement", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void SetSystemWideReplacement (string fullName, global::Java.Lang.Object replacement)
		{
			const string __id = "setSystemWideReplacement.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_fullName = JNIEnv.NewString (fullName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fullName);
				__args [1] = new JniArgumentValue ((replacement == null) ? IntPtr.Zero : ((global::Java.Lang.Object) replacement).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fullName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content.res']/class[@name='XResources']/method[@name='setSystemWideReplacement' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object']]"
		[Register ("setSystemWideReplacement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void SetSystemWideReplacement (string pkg, string type, string name, global::Java.Lang.Object replacement)
		{
			const string __id = "setSystemWideReplacement.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_pkg = JNIEnv.NewString (pkg);
			IntPtr native_type = JNIEnv.NewString (type);
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_pkg);
				__args [1] = new JniArgumentValue (native_type);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue ((replacement == null) ? IntPtr.Zero : ((global::Java.Lang.Object) replacement).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pkg);
				JNIEnv.DeleteLocalRef (native_type);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
