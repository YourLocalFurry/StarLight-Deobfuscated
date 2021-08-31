using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using MelonLoader;

namespace Starlight
{
	// Token: 0x0200000B RID: 11
	public class StarLightLoader : MelonMod
	{
		// Token: 0x06000025 RID: 37 RVA: 0x0001E574 File Offset: 0x00017D74
		internal static long smethod_0()
		{
			return -5174102234038325131L;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0001EEC4 File Offset: 0x000186C4
		public override void OnApplicationStart()
		{
			StarLightLoader.Starlightpatch = this;
			try
			{
				MelonCoroutines.Start(DllProtections.DllProtection());
			}
			catch
			{
			}
			byte[] array = null;
			if (File.Exists(Directory.GetCurrentDirectory() + "\\Starlight\\StarlightCore.dll"))
			{
				array = File.ReadAllBytes(Directory.GetCurrentDirectory() + "\\Starlight\\StarlightCore.dll");
			}
			WebClient webClient = new WebClient();
			webClient.Headers["User-Agent"] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:87.0) Gecko/20100101 Firefox/87.0";
			using (WebClient webClient2 = webClient)
			{
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cHM6Ly9sb2xpY2xpZW50LjAwMHdlYmhvc3RhcHAuY29tL1N0YXJsaWdodENvcmUuZGxs"));
				byte[] array2 = webClient2.DownloadData(@string);
				if (array == null)
				{
					if (array2 == null)
					{
						MelonLogger.Error("Unable to download latest version of Starlight");
						return;
					}
					array = array2;
				}
				Assembly assembly;
				try
				{
					assembly = Assembly.Load(array);
				}
				catch (BadImageFormatException arg)
				{
					MelonLogger.Error(string.Format("Couldn't load specified image: {0}", arg));
					return;
				}
				IEnumerable<Type> source;
				try
				{
					source = assembly.GetTypes();
				}
				catch (ReflectionTypeLoadException ex)
				{
					source = ex.Types.Where(new Func<Type, bool>(StarLightLoader.Class4.class4_0.method_0));
				}
				Type type = source.FirstOrDefault(new Func<Type, bool>(StarLightLoader.Class4.class4_0.method_1));
				if (type == null)
				{
					MelonLogger.Error("Couldn't find Load :(");
				}
				else
				{
					MethodInfo[] methods = type.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
					foreach (MethodInfo methodInfo in methods)
					{
						ParameterInfo[] parameters = methodInfo.GetParameters();
						string name = methodInfo.Name;
						string text = name;
						uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
						if (num <= 1876246349U)
						{
							if (num <= 447148526U)
							{
								if (num != 417623683U)
								{
									if (num == 447148526U)
									{
										if (text == "OnApplicationStart" && parameters.Length == 0)
										{
											this.action_0 = (Action)Delegate.CreateDelegate(typeof(Action), methodInfo);
										}
									}
								}
								else if (text == "OnFixedUpdate" && parameters.Length == 0)
								{
									this.action_2 = (Action)Delegate.CreateDelegate(typeof(Action), methodInfo);
								}
							}
							else if (num != 1037902400U)
							{
								if (num != 1054471185U)
								{
									if (num == 1876246349U)
									{
										if (text == "OnLateUpdate" && parameters.Length == 0)
										{
											this.action_5 = (Action)Delegate.CreateDelegate(typeof(Action), methodInfo);
										}
									}
								}
								else if (text == "OnUpdate" && parameters.Length == 0)
								{
									this.action_3 = (Action)Delegate.CreateDelegate(typeof(Action), methodInfo);
								}
							}
							else if (text == "OnSceneWasLoaded" && parameters.Length == 2 && parameters[0].ParameterType == typeof(int) && parameters[1].ParameterType == typeof(string))
							{
								this.action_8 = (Action<int, string>)Delegate.CreateDelegate(typeof(Action<int, string>), methodInfo);
							}
						}
						else if (num <= 2527855275U)
						{
							if (num != 2096983945U)
							{
								if (num != 2192928915U)
								{
									if (num == 2527855275U)
									{
										if (text == "OnGUI" && parameters.Length == 0)
										{
											this.action_4 = (Action)Delegate.CreateDelegate(typeof(Action), methodInfo);
										}
									}
								}
								else if (text == "OnPreferencesLoaded" && parameters.Length == 0)
								{
									this.action_6 = (Action)Delegate.CreateDelegate(typeof(Action), methodInfo);
								}
							}
							else if (text == "OnPreferencesSaved" && parameters.Length == 0)
							{
								this.action_7 = (Action)Delegate.CreateDelegate(typeof(Action), methodInfo);
							}
						}
						else if (num != 3369347111U)
						{
							if (num != 4044107837U)
							{
								if (num == 4095070261U)
								{
									if (text == "OnApplicationQuit" && parameters.Length == 0)
									{
										this.SjjtZoiq8 = (Action)Delegate.CreateDelegate(typeof(Action), methodInfo);
									}
								}
							}
							else if (text == "OnSceneWasInitialized" && parameters.Length == 2 && parameters[0].ParameterType == typeof(int) && parameters[1].ParameterType == typeof(string))
							{
								this.action_9 = (Action<int, string>)Delegate.CreateDelegate(typeof(Action<int, string>), methodInfo);
							}
						}
						else if (text == "OnUiManagerInit" && parameters.Length == 0)
						{
							this.action_1 = (Action)Delegate.CreateDelegate(typeof(Action), methodInfo);
						}
					}
					MelonCoroutines.Start(this.method_0());
					this.action_0();
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0001E0E0 File Offset: 0x000178E0
		public void OnUiManagerInit()
		{
			this.action_1();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0001E0ED File Offset: 0x000178ED
		public override void OnFixedUpdate()
		{
			this.action_2();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0001E0FA File Offset: 0x000178FA
		public override void OnUpdate()
		{
			this.action_3();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0001E107 File Offset: 0x00017907
		public override void OnLateUpdate()
		{
			this.action_5();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0001E114 File Offset: 0x00017914
		public override void OnGUI()
		{
			this.action_4();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0001E121 File Offset: 0x00017921
		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			this.action_8(buildIndex, sceneName);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0001E130 File Offset: 0x00017930
		public override void OnSceneWasInitialized(int buildIndex, string sceneName)
		{
			this.action_9(buildIndex, sceneName);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0001E13F File Offset: 0x0001793F
		public override void OnApplicationQuit()
		{
			this.SjjtZoiq8();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0001E14C File Offset: 0x0001794C
		public override void OnPreferencesLoaded()
		{
			this.action_6();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0001E159 File Offset: 0x00017959
		public override void OnPreferencesSaved()
		{
			this.action_7();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0001E166 File Offset: 0x00017966
		private IEnumerator method_0()
		{
			StarLightLoader.<WaitForUiManager>d__25 <WaitForUiManager>d__ = new StarLightLoader.<WaitForUiManager>d__25(0);
			<WaitForUiManager>d__.<>4__this = this;
			return <WaitForUiManager>d__;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0001F468 File Offset: 0x00018C68
		private static string smethod_1(HashAlgorithm hashAlgorithm_0, byte[] byte_0)
		{
			byte[] array = hashAlgorithm_0.ComputeHash(byte_0);
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2"));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0001E175 File Offset: 0x00017975
		public StarLightLoader()
		{
			Class10.mLqA1qsz6sJ2l();
			base..ctor();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0001E048 File Offset: 0x00017848
		// Note: this type is marked as 'beforefieldinit'.
		static StarLightLoader()
		{
			Class11.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x04000016 RID: 22
		private Action action_0;

		// Token: 0x04000017 RID: 23
		private Action action_1;

		// Token: 0x04000018 RID: 24
		private Action action_2;

		// Token: 0x04000019 RID: 25
		private Action action_3;

		// Token: 0x0400001A RID: 26
		private Action action_4;

		// Token: 0x0400001B RID: 27
		private Action SjjtZoiq8;

		// Token: 0x0400001C RID: 28
		private Action action_5;

		// Token: 0x0400001D RID: 29
		private Action action_6;

		// Token: 0x0400001E RID: 30
		private Action action_7;

		// Token: 0x0400001F RID: 31
		private Action<int, string> action_8;

		// Token: 0x04000020 RID: 32
		private Action<int, string> action_9;

		// Token: 0x04000021 RID: 33
		public static StarLightLoader Starlightpatch;

		// Token: 0x0200000C RID: 12
		[CompilerGenerated]
		[Serializable]
		private sealed class Class4
		{
			// Token: 0x06000035 RID: 53 RVA: 0x0001E182 File Offset: 0x00017982
			// Note: this type is marked as 'beforefieldinit'.
			static Class4()
			{
				Class11.kLjw4iIsCLsZtxc4lksN0j();
				Class10.mLqA1qsz6sJ2l();
				StarLightLoader.Class4.class4_0 = new StarLightLoader.Class4();
			}

			// Token: 0x06000036 RID: 54 RVA: 0x0001E0AE File Offset: 0x000178AE
			public Class4()
			{
				Class10.mLqA1qsz6sJ2l();
				base..ctor();
			}

			// Token: 0x06000037 RID: 55 RVA: 0x0001E198 File Offset: 0x00017998
			internal bool method_0(Type t)
			{
				return t != null;
			}

			// Token: 0x06000038 RID: 56 RVA: 0x0001E1A1 File Offset: 0x000179A1
			internal bool method_1(Type type)
			{
				return type.Name == "Load";
			}

			// Token: 0x04000022 RID: 34
			public static readonly StarLightLoader.Class4 class4_0;

			// Token: 0x04000023 RID: 35
			public static Func<Type, bool> func_0;

			// Token: 0x04000024 RID: 36
			public static Func<Type, bool> func_1;
		}
	}
}
