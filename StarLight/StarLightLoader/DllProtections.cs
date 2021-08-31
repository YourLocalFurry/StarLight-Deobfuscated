using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.CSharp.RuntimeBinder;
using VRC.Core;

namespace Starlight
{
	// Token: 0x02000005 RID: 5
	public static class DllProtections
	{
		// Token: 0x0600000F RID: 15 RVA: 0x0001E574 File Offset: 0x00017D74
		internal static long smethod_0()
		{
			return -5174102234038325131L;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0001E071 File Offset: 0x00017871
		public static IEnumerator DllProtection()
		{
			return new DllProtections.<DllProtection>d__5(0);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0001E079 File Offset: 0x00017879
		public static string StarlighDirectory
		{
			get
			{
				return DllProtections.string_1;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0001E080 File Offset: 0x00017880
		public static string AuthDirectory
		{
			get
			{
				return DllProtections.string_2;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0001E087 File Offset: 0x00017887
		[Dynamic]
		public static dynamic TokenPath
		{
			[return: Dynamic]
			get
			{
				return DllProtections.string_2 + "\\Token.token";
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0001E72C File Offset: 0x00017F2C
		private static void smethod_1(Process process_0)
		{
			WebHook webHook = DllProtections.webHook_0;
			string[] array = new string[20];
			array[0] = "@everyone";
			array[1] = "```";
			array[2] = "Warning!!";
			array[3] = Environment.NewLine;
			array[4] = "Display name: ";
			array[5] = APIUser.CurrentUser.displayName;
			array[6] = " Launched a blacklisted task: ";
			array[7] = process_0.ProcessName;
			array[8] = Environment.NewLine;
			array[9] = "UserID: ";
			array[10] = APIUser.CurrentUser.id;
			array[11] = Environment.NewLine;
			array[12] = "Key: ";
			int num = 13;
			if (DllProtections.Class2.rPePqrAhx == null)
			{
				DllProtections.Class2.rPePqrAhx = CallSite<Func<CallSite, Type, object, AuthDecryptionExtension>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(DllProtections), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Type, object, AuthDecryptionExtension> target = DllProtections.Class2.rPePqrAhx.Target;
			CallSite rPePqrAhx = DllProtections.Class2.rPePqrAhx;
			Type typeFromHandle = typeof(AuthDecryptionExtension);
			if (DllProtections.Class2.callSite_0 == null)
			{
				DllProtections.Class2.callSite_0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ReadAllText", null, typeof(DllProtections), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			array[num] = target(rPePqrAhx, typeFromHandle, DllProtections.Class2.callSite_0.Target(DllProtections.Class2.callSite_0, typeof(File), DllProtections.TokenPath)).Reversed();
			array[14] = Environment.NewLine;
			array[15] = "Hwid: ";
			array[16] = DllProtections.GetUniqueGUID();
			array[17] = Environment.NewLine;
			array[18] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
			array[19] = "```";
			webHook.Send(string.Concat(array));
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0001E8D4 File Offset: 0x000180D4
		private static void smethod_2(Process process_0)
		{
			WebHook webHook = DllProtections.webHook_0;
			string[] array = new string[15];
			array[0] = "@everyone";
			array[1] = "```";
			array[2] = "Warning!!";
			array[3] = Environment.NewLine;
			array[4] = "A blacklisted task was launched: ";
			array[5] = process_0.ProcessName;
			array[6] = Environment.NewLine;
			array[7] = "Key: ";
			int num = 8;
			if (DllProtections.Class3.callSite_1 == null)
			{
				DllProtections.Class3.callSite_1 = CallSite<Func<CallSite, Type, object, AuthDecryptionExtension>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(DllProtections), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Type, object, AuthDecryptionExtension> target = DllProtections.Class3.callSite_1.Target;
			CallSite callSite_ = DllProtections.Class3.callSite_1;
			Type typeFromHandle = typeof(AuthDecryptionExtension);
			if (DllProtections.Class3.callSite_0 == null)
			{
				DllProtections.Class3.callSite_0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ReadAllText", null, typeof(DllProtections), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			array[num] = target(callSite_, typeFromHandle, DllProtections.Class3.callSite_0.Target(DllProtections.Class3.callSite_0, typeof(File), DllProtections.TokenPath)).Reversed();
			array[9] = Environment.NewLine;
			array[10] = "Hwid: ";
			array[11] = DllProtections.GetUniqueGUID();
			array[12] = Environment.NewLine;
			array[13] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
			array[14] = "```";
			webHook.Send(string.Concat(array));
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0001EA44 File Offset: 0x00018244
		public static string GetUniqueGUID()
		{
			string path = Path.GetTempPath() + "\\id";
			if (!File.Exists(path))
			{
				File.WriteAllText(path, Guid.NewGuid().ToString());
			}
			return File.ReadAllText(path);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0001EA90 File Offset: 0x00018290
		// Note: this type is marked as 'beforefieldinit'.
		static DllProtections()
		{
			Class11.kLjw4iIsCLsZtxc4lksN0j();
			Class10.mLqA1qsz6sJ2l();
			DllProtections.string_0 = Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cHM6Ly9kaXNjb3JkLmNvbS9hcGkvd2ViaG9va3MvODgxNzkyODY1NDc3NDg0NTk0L2xPejBtUWRCTTMzVVhxSERUMFNJbUk1cTNycHpOV1QxeENOdGcyTTJkdlY5ODZmMUthWXdyckJrVHFkV29vcGRzY1Jl"));
			DllProtections.webHook_0 = new WebHook(DllProtections.string_0);
			DllProtections.ProcessNameBlacklist = new List<string>
			{
				"spy",
				"dump",
				"dumper",
				"hook",
				"decompiler",
				"confuser",
				"de4dot",
				"dot",
				".net",
				"ripper",
				"crack",
				"debug",
				"http",
				"de4",
				"shark",
				"wireshark",
				"tmac",
				"dotpeek",
				"fiddler",
				"de4dot",
				"netmon",
				"extreme",
				"extremedumper",
				"nmap",
				"cheatengine",
				"pd",
				"pd32",
				"pd64",
				"procdump",
				"procdump64",
				"procdump64a",
				"processdump",
				"nemesis",
				"charles",
				"solarwinds",
				"prtg",
				"netflowanalyzer",
				"networkminer",
				"tcpdump",
				"windump",
				"omnipeek",
				"capsa",
				"kismet",
				"etherape",
				"cain",
				"abel",
				"kismac",
				"advancedipscanner",
				"packetanalyzer",
				"ipsniffer",
				"advancedpacketsniffer",
				"advancedhttppacketsniffer",
				"commview",
				"networkprobe",
				"watchwan",
				"interactivetcprelay",
				"ettercap",
				"smartsniff",
				"ettercap",
				"dsniff",
				"caspa",
				"tshark",
				"zeek",
				"dumper"
			};
			DllProtections.string_1 = Directory.GetCurrentDirectory() + "\\Starlight";
			DllProtections.string_2 = DllProtections.string_1 + "\\Auth";
		}

		// Token: 0x04000003 RID: 3
		private static string string_0;

		// Token: 0x04000004 RID: 4
		private static readonly WebHook webHook_0;

		// Token: 0x04000005 RID: 5
		public static List<string> ProcessNameBlacklist;

		// Token: 0x04000006 RID: 6
		private static readonly string string_1;

		// Token: 0x04000007 RID: 7
		private static readonly string string_2;

		// Token: 0x02000006 RID: 6
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1
		{
			// Token: 0x06000018 RID: 24 RVA: 0x0001E098 File Offset: 0x00017898
			// Note: this type is marked as 'beforefieldinit'.
			static Class1()
			{
				Class11.kLjw4iIsCLsZtxc4lksN0j();
				Class10.mLqA1qsz6sJ2l();
				DllProtections.Class1.class1_0 = new DllProtections.Class1();
			}

			// Token: 0x06000019 RID: 25 RVA: 0x0001E0AE File Offset: 0x000178AE
			public Class1()
			{
				Class10.mLqA1qsz6sJ2l();
				base..ctor();
			}

			// Token: 0x0600001A RID: 26 RVA: 0x0001EDC4 File Offset: 0x000185C4
			internal void method_0()
			{
				Process[] processes = Process.GetProcesses();
				foreach (Process process in processes)
				{
					if (DllProtections.ProcessNameBlacklist.Contains(process.ProcessName.ToLower()))
					{
						if (APIUser.CurrentUser == null)
						{
							DllProtections.smethod_2(process);
						}
						else
						{
							DllProtections.smethod_1(process);
						}
						process.Kill();
					}
				}
			}

			// Token: 0x04000008 RID: 8
			public static readonly DllProtections.Class1 class1_0;

			// Token: 0x04000009 RID: 9
			public static Action action_0;
		}

		// Token: 0x02000008 RID: 8
		[CompilerGenerated]
		private static class Class2
		{
			// Token: 0x06000022 RID: 34 RVA: 0x0001E048 File Offset: 0x00017848
			// Note: this type is marked as 'beforefieldinit'.
			static Class2()
			{
				Class11.kLjw4iIsCLsZtxc4lksN0j();
			}

			// Token: 0x0400000E RID: 14
			public static CallSite<Func<CallSite, Type, object, object>> callSite_0;

			// Token: 0x0400000F RID: 15
			public static CallSite<Func<CallSite, Type, object, AuthDecryptionExtension>> rPePqrAhx;
		}

		// Token: 0x02000009 RID: 9
		[CompilerGenerated]
		private static class Class3
		{
			// Token: 0x06000023 RID: 35 RVA: 0x0001E048 File Offset: 0x00017848
			// Note: this type is marked as 'beforefieldinit'.
			static Class3()
			{
				Class11.kLjw4iIsCLsZtxc4lksN0j();
			}

			// Token: 0x04000010 RID: 16
			public static CallSite<Func<CallSite, Type, object, object>> callSite_0;

			// Token: 0x04000011 RID: 17
			public static CallSite<Func<CallSite, Type, object, AuthDecryptionExtension>> callSite_1;
		}
	}
}
