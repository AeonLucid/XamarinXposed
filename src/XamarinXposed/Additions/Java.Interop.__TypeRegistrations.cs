using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"de/robv/android/xposed",
						"de/robv/android/xposed/callbacks",
						"de/robv/android/xposed/services",
					},
					new Converter<string, Type>[]{
						lookup_de_robv_android_xposed_package,
						lookup_de_robv_android_xposed_callbacks_package,
						lookup_de_robv_android_xposed_services_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_de_robv_android_xposed_mappings;
		static Type lookup_de_robv_android_xposed_package (string klass)
		{
			if (package_de_robv_android_xposed_mappings == null) {
				package_de_robv_android_xposed_mappings = new string[]{
					"de/robv/android/xposed/IXposedHookZygoteInit$StartupParam:Xposed.XposedHookZygoteInitStartupParam",
					"de/robv/android/xposed/SELinuxHelper:Xposed.SELinuxHelper",
					"de/robv/android/xposed/XC_MethodHook:Xposed.XC_MethodHook",
					"de/robv/android/xposed/XC_MethodHook$MethodHookParam:Xposed.XC_MethodHook/MethodHookParam",
					"de/robv/android/xposed/XC_MethodHook$Unhook:Xposed.XC_MethodHook/Unhook",
					"de/robv/android/xposed/XC_MethodReplacement:Xposed.XC_MethodReplacement",
					"de/robv/android/xposed/XposedBridge:Xposed.XposedBridge",
					"de/robv/android/xposed/XposedHelpers:Xposed.XposedHelpers",
					"de/robv/android/xposed/XposedHelpers$ClassNotFoundError:Xposed.XposedHelpers/ClassNotFoundError",
					"de/robv/android/xposed/XposedHelpers$InvocationTargetError:Xposed.XposedHelpers/InvocationTargetError",
					"de/robv/android/xposed/XSharedPreferences:Xposed.XSharedPreferences",
				};
			}

			return Lookup (package_de_robv_android_xposed_mappings, klass);
		}

		static string[] package_de_robv_android_xposed_callbacks_mappings;
		static Type lookup_de_robv_android_xposed_callbacks_package (string klass)
		{
			if (package_de_robv_android_xposed_callbacks_mappings == null) {
				package_de_robv_android_xposed_callbacks_mappings = new string[]{
					"de/robv/android/xposed/callbacks/XC_InitPackageResources:Xposed.Callbacks.XC_InitPackageResources",
					"de/robv/android/xposed/callbacks/XC_InitPackageResources$InitPackageResourcesParam:Xposed.Callbacks.XC_InitPackageResources/InitPackageResourcesParam",
					"de/robv/android/xposed/callbacks/XC_LayoutInflated:Xposed.Callbacks.XC_LayoutInflated",
					"de/robv/android/xposed/callbacks/XC_LayoutInflated$LayoutInflatedParam:Xposed.Callbacks.XC_LayoutInflated/LayoutInflatedParam",
					"de/robv/android/xposed/callbacks/XC_LayoutInflated$Unhook:Xposed.Callbacks.XC_LayoutInflated/Unhook",
					"de/robv/android/xposed/callbacks/XC_LoadPackage:Xposed.Callbacks.XC_LoadPackage",
					"de/robv/android/xposed/callbacks/XC_LoadPackage$LoadPackageParam:Xposed.Callbacks.XC_LoadPackage/LoadPackageParam",
					"de/robv/android/xposed/callbacks/XCallback:Xposed.Callbacks.XCallback",
					"de/robv/android/xposed/callbacks/XCallback$Param:Xposed.Callbacks.XCallback/Param",
				};
			}

			return Lookup (package_de_robv_android_xposed_callbacks_mappings, klass);
		}

		static string[] package_de_robv_android_xposed_services_mappings;
		static Type lookup_de_robv_android_xposed_services_package (string klass)
		{
			if (package_de_robv_android_xposed_services_mappings == null) {
				package_de_robv_android_xposed_services_mappings = new string[]{
					"de/robv/android/xposed/services/BaseService:Xposed.Services.BaseService",
					"de/robv/android/xposed/services/FileResult:Xposed.Services.FileResult",
				};
			}

			return Lookup (package_de_robv_android_xposed_services_mappings, klass);
		}
	}
}
