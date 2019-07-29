using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Xposed.Services {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='FileResult']"
	[global::Android.Runtime.Register ("de/robv/android/xposed/services/FileResult", DoNotGenerateAcw=true)]
	public sealed partial class FileResult : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='FileResult']/field[@name='content']"
		[Register ("content")]
		public IList<byte> Content {
			get {
				const string __id = "content.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "content.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='FileResult']/field[@name='mtime']"
		[Register ("mtime")]
		public long Mtime {
			get {
				const string __id = "mtime.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mtime.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='FileResult']/field[@name='size']"
		[Register ("size")]
		public long Size {
			get {
				const string __id = "size.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "size.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='de.robv.android.xposed.services']/class[@name='FileResult']/field[@name='stream']"
		[Register ("stream")]
		public global::System.IO.Stream Stream {
			get {
				const string __id = "stream.Ljava/io/InputStream;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stream.Ljava/io/InputStream;";

				IntPtr native_value = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("de/robv/android/xposed/services/FileResult", typeof (FileResult));
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

		internal FileResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
