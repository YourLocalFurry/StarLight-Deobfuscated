using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

// Token: 0x02000013 RID: 19
internal class Class6
{
	// Token: 0x06000053 RID: 83 RVA: 0x0001F630 File Offset: 0x00018E30
	static Class6()
	{
		Class11.kLjw4iIsCLsZtxc4lksN0j();
		Class6.bool_5 = false;
		Class6.assembly_0 = typeof(Class6).Assembly;
		Class6.uint_0 = new uint[]
		{
			3614090360U,
			3905402710U,
			606105819U,
			3250441966U,
			4118548399U,
			1200080426U,
			2821735955U,
			4249261313U,
			1770035416U,
			2336552879U,
			4294925233U,
			2304563134U,
			1804603682U,
			4254626195U,
			2792965006U,
			1236535329U,
			4129170786U,
			3225465664U,
			643717713U,
			3921069994U,
			3593408605U,
			38016083U,
			3634488961U,
			3889429448U,
			568446438U,
			3275163606U,
			4107603335U,
			1163531501U,
			2850285829U,
			4243563512U,
			1735328473U,
			2368359562U,
			4294588738U,
			2272392833U,
			1839030562U,
			4259657740U,
			2763975236U,
			1272893353U,
			4139469664U,
			3200236656U,
			681279174U,
			3936430074U,
			3572445317U,
			76029189U,
			3654602809U,
			3873151461U,
			530742520U,
			3299628645U,
			4096336452U,
			1126891415U,
			2878612391U,
			4237533241U,
			1700485571U,
			2399980690U,
			4293915773U,
			2240044497U,
			1873313359U,
			4264355552U,
			2734768916U,
			1309151649U,
			4149444226U,
			3174756917U,
			718787259U,
			3951481745U
		};
		Class6.bool_0 = false;
		Class6.bool_3 = false;
		Class6.byte_2 = new byte[0];
		Class6.byte_0 = new byte[0];
		Class6.dictionary_0 = null;
		Class6.fFbIlVunGp = new object();
		Class6.byte_3 = new byte[0];
		Class6.byte_1 = new byte[0];
		Class6.intptr_1 = IntPtr.Zero;
		Class6.intptr_0 = IntPtr.Zero;
		Class6.string_0 = new string[0];
		Class6.int_0 = new int[0];
		Class6.int_4 = 1;
		Class6.bool_1 = false;
		Class6.sortedList_0 = new SortedList();
		Class6.int_1 = 0;
		Class6.long_1 = 0L;
		Class6.delegate2_0 = null;
		Class6.delegate2_1 = null;
		Class6.long_0 = 0L;
		Class6.int_3 = 0;
		Class6.bool_4 = false;
		Class6.bool_6 = false;
		Class6.int_2 = 0;
		Class6.intptr_3 = IntPtr.Zero;
		Class6.bool_2 = false;
		Class6.hashtable_0 = new Hashtable();
		Class6.delegate4_0 = null;
		Class6.delegate5_0 = null;
		Class6.delegate6_0 = null;
		Class6.delegate7_0 = null;
		Class6.delegate8_0 = null;
		Class6.delegate9_0 = null;
		Class6.intptr_2 = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x06000054 RID: 84 RVA: 0x0001E0CF File Offset: 0x000178CF
	private void IWfA1qsmrhhMI()
	{
	}

	// Token: 0x06000055 RID: 85 RVA: 0x0001F7A4 File Offset: 0x00018FA4
	internal static byte[] smethod_0(byte[] byte_4)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - byte_4.Length * 8 % 512 + 512) % 512);
		if (num == 0U)
		{
			num = 512U;
		}
		uint num2 = (uint)((long)byte_4.Length + (long)((ulong)(num / 8U)) + 8L);
		ulong num3 = (ulong)((long)byte_4.Length * 8L);
		byte[] array2 = new byte[num2];
		for (int i = 0; i < byte_4.Length; i++)
		{
			array2[i] = byte_4[i];
		}
		byte[] array3 = array2;
		int num4 = byte_4.Length;
		array3[num4] |= 128;
		for (int j = 8; j > 0; j--)
		{
			array2[(int)(checked((IntPtr)(unchecked((ulong)num2 - (ulong)((long)j)))))] = (byte)(num3 >> (8 - j) * 8 & 255UL);
		}
		uint num5 = (uint)(array2.Length * 8 / 32);
		uint num6 = 1732584193U;
		uint num7 = 4023233417U;
		uint num8 = 2562383102U;
		uint num9 = 271733878U;
		for (uint num10 = 0U; num10 < num5 / 16U; num10 += 1U)
		{
			uint num11 = num10 << 6;
			for (uint num12 = 0U; num12 < 61U; num12 += 4U)
			{
				array[(int)(num12 >> 2)] = (uint)((int)array2[(int)(num11 + (num12 + 3U))] << 24 | (int)array2[(int)(num11 + (num12 + 2U))] << 16 | (int)array2[(int)(num11 + (num12 + 1U))] << 8 | (int)array2[(int)(num11 + num12)]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			Class6.smethod_1(ref num6, num7, num8, num9, 0U, 7, 1U, array);
			Class6.smethod_1(ref num9, num6, num7, num8, 1U, 12, 2U, array);
			Class6.smethod_1(ref num8, num9, num6, num7, 2U, 17, 3U, array);
			Class6.smethod_1(ref num7, num8, num9, num6, 3U, 22, 4U, array);
			Class6.smethod_1(ref num6, num7, num8, num9, 4U, 7, 5U, array);
			Class6.smethod_1(ref num9, num6, num7, num8, 5U, 12, 6U, array);
			Class6.smethod_1(ref num8, num9, num6, num7, 6U, 17, 7U, array);
			Class6.smethod_1(ref num7, num8, num9, num6, 7U, 22, 8U, array);
			Class6.smethod_1(ref num6, num7, num8, num9, 8U, 7, 9U, array);
			Class6.smethod_1(ref num9, num6, num7, num8, 9U, 12, 10U, array);
			Class6.smethod_1(ref num8, num9, num6, num7, 10U, 17, 11U, array);
			Class6.smethod_1(ref num7, num8, num9, num6, 11U, 22, 12U, array);
			Class6.smethod_1(ref num6, num7, num8, num9, 12U, 7, 13U, array);
			Class6.smethod_1(ref num9, num6, num7, num8, 13U, 12, 14U, array);
			Class6.smethod_1(ref num8, num9, num6, num7, 14U, 17, 15U, array);
			Class6.smethod_1(ref num7, num8, num9, num6, 15U, 22, 16U, array);
			Class6.smethod_2(ref num6, num7, num8, num9, 1U, 5, 17U, array);
			Class6.smethod_2(ref num9, num6, num7, num8, 6U, 9, 18U, array);
			Class6.smethod_2(ref num8, num9, num6, num7, 11U, 14, 19U, array);
			Class6.smethod_2(ref num7, num8, num9, num6, 0U, 20, 20U, array);
			Class6.smethod_2(ref num6, num7, num8, num9, 5U, 5, 21U, array);
			Class6.smethod_2(ref num9, num6, num7, num8, 10U, 9, 22U, array);
			Class6.smethod_2(ref num8, num9, num6, num7, 15U, 14, 23U, array);
			Class6.smethod_2(ref num7, num8, num9, num6, 4U, 20, 24U, array);
			Class6.smethod_2(ref num6, num7, num8, num9, 9U, 5, 25U, array);
			Class6.smethod_2(ref num9, num6, num7, num8, 14U, 9, 26U, array);
			Class6.smethod_2(ref num8, num9, num6, num7, 3U, 14, 27U, array);
			Class6.smethod_2(ref num7, num8, num9, num6, 8U, 20, 28U, array);
			Class6.smethod_2(ref num6, num7, num8, num9, 13U, 5, 29U, array);
			Class6.smethod_2(ref num9, num6, num7, num8, 2U, 9, 30U, array);
			Class6.smethod_2(ref num8, num9, num6, num7, 7U, 14, 31U, array);
			Class6.smethod_2(ref num7, num8, num9, num6, 12U, 20, 32U, array);
			Class6.smethod_3(ref num6, num7, num8, num9, 5U, 4, 33U, array);
			Class6.smethod_3(ref num9, num6, num7, num8, 8U, 11, 34U, array);
			Class6.smethod_3(ref num8, num9, num6, num7, 11U, 16, 35U, array);
			Class6.smethod_3(ref num7, num8, num9, num6, 14U, 23, 36U, array);
			Class6.smethod_3(ref num6, num7, num8, num9, 1U, 4, 37U, array);
			Class6.smethod_3(ref num9, num6, num7, num8, 4U, 11, 38U, array);
			Class6.smethod_3(ref num8, num9, num6, num7, 7U, 16, 39U, array);
			Class6.smethod_3(ref num7, num8, num9, num6, 10U, 23, 40U, array);
			Class6.smethod_3(ref num6, num7, num8, num9, 13U, 4, 41U, array);
			Class6.smethod_3(ref num9, num6, num7, num8, 0U, 11, 42U, array);
			Class6.smethod_3(ref num8, num9, num6, num7, 3U, 16, 43U, array);
			Class6.smethod_3(ref num7, num8, num9, num6, 6U, 23, 44U, array);
			Class6.smethod_3(ref num6, num7, num8, num9, 9U, 4, 45U, array);
			Class6.smethod_3(ref num9, num6, num7, num8, 12U, 11, 46U, array);
			Class6.smethod_3(ref num8, num9, num6, num7, 15U, 16, 47U, array);
			Class6.smethod_3(ref num7, num8, num9, num6, 2U, 23, 48U, array);
			Class6.smethod_4(ref num6, num7, num8, num9, 0U, 6, 49U, array);
			Class6.smethod_4(ref num9, num6, num7, num8, 7U, 10, 50U, array);
			Class6.smethod_4(ref num8, num9, num6, num7, 14U, 15, 51U, array);
			Class6.smethod_4(ref num7, num8, num9, num6, 5U, 21, 52U, array);
			Class6.smethod_4(ref num6, num7, num8, num9, 12U, 6, 53U, array);
			Class6.smethod_4(ref num9, num6, num7, num8, 3U, 10, 54U, array);
			Class6.smethod_4(ref num8, num9, num6, num7, 10U, 15, 55U, array);
			Class6.smethod_4(ref num7, num8, num9, num6, 1U, 21, 56U, array);
			Class6.smethod_4(ref num6, num7, num8, num9, 8U, 6, 57U, array);
			Class6.smethod_4(ref num9, num6, num7, num8, 15U, 10, 58U, array);
			Class6.smethod_4(ref num8, num9, num6, num7, 6U, 15, 59U, array);
			Class6.smethod_4(ref num7, num8, num9, num6, 13U, 21, 60U, array);
			Class6.smethod_4(ref num6, num7, num8, num9, 4U, 6, 61U, array);
			Class6.smethod_4(ref num9, num6, num7, num8, 11U, 10, 62U, array);
			Class6.smethod_4(ref num8, num9, num6, num7, 2U, 15, 63U, array);
			Class6.smethod_4(ref num7, num8, num9, num6, 9U, 21, 64U, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array4 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num6), 0, array4, 0, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array4, 4, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array4, 8, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array4, 12, 4);
		return array4;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x0001E246 File Offset: 0x00017A46
	private static void smethod_1(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class6.smethod_5(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + uint_7[(int)uint_5] + Class6.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000057 RID: 87 RVA: 0x0001E26F File Offset: 0x00017A6F
	private static void smethod_2(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class6.smethod_5(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + uint_7[(int)uint_5] + Class6.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000058 RID: 88 RVA: 0x0001E298 File Offset: 0x00017A98
	private static void smethod_3(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class6.smethod_5(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + uint_7[(int)uint_5] + Class6.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000059 RID: 89 RVA: 0x0001E2BE File Offset: 0x00017ABE
	private static void smethod_4(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class6.smethod_5(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + uint_7[(int)uint_5] + Class6.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x0600005A RID: 90 RVA: 0x0001E2E5 File Offset: 0x00017AE5
	private static uint smethod_5(uint uint_1, ushort ushort_0)
	{
		return uint_1 >> (int)(32 - ushort_0) | uint_1 << (int)ushort_0;
	}

	// Token: 0x0600005B RID: 91 RVA: 0x0001E2F7 File Offset: 0x00017AF7
	internal static bool smethod_6()
	{
		if (!Class6.bool_0)
		{
			Class6.smethod_8();
			Class6.bool_0 = true;
		}
		return Class6.bool_3;
	}

	// Token: 0x0600005C RID: 92 RVA: 0x0001FE04 File Offset: 0x00019604
	internal static SymmetricAlgorithm smethod_7()
	{
		SymmetricAlgorithm result = null;
		if (Class6.smethod_6())
		{
			result = new AesCryptoServiceProvider();
		}
		else
		{
			try
			{
				result = new RijndaelManaged();
			}
			catch
			{
				result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
			}
		}
		return result;
	}

	// Token: 0x0600005D RID: 93 RVA: 0x0001FE5C File Offset: 0x0001965C
	internal static void smethod_8()
	{
		try
		{
			Class6.bool_3 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	// Token: 0x0600005E RID: 94 RVA: 0x0001E310 File Offset: 0x00017B10
	internal static byte[] smethod_9(byte[] byte_4)
	{
		if (!Class6.smethod_6())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_4);
		}
		return Class6.smethod_0(byte_4);
	}

	// Token: 0x0600005F RID: 95 RVA: 0x0001FE88 File Offset: 0x00019688
	public static void smethod_10(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (Class6.dictionary_0 == null)
			{
				object obj = Class6.fFbIlVunGp;
				lock (obj)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(Class6).Assembly.GetManifestResourceStream("yE3P2wPiOYsBoBAvMn.oRUyss59RN1LGk2yn6"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length != 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0U;
						if (num > 0)
						{
							num2++;
						}
						for (int i = 0; i < num2; i++)
						{
							int num4 = i * 4;
							uint num5 = 255U;
							int num6 = 0;
							uint num7;
							if (i == num2 - 1 && num > 0)
							{
								num7 = 0U;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num7 <<= 8;
									}
									num7 |= (uint)array[array.Length - (1 + j)];
								}
							}
							else
							{
								uint num8 = (uint)num4;
								num7 = (uint)((int)array[(int)(num8 + 3U)] << 24 | (int)array[(int)(num8 + 2U)] << 16 | (int)array[(int)(num8 + 1U)] << 8 | (int)array[(int)num8]);
							}
							num3 = num3;
							num3 += 0U;
							if (i == num2 - 1 && num > 0)
							{
								uint num9 = num3 ^ num7;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num5 <<= 8;
										num6 += 8;
									}
									array2[num4 + k] = (byte)((num9 & num5) >> num6);
								}
							}
							else
							{
								uint num10 = num3 ^ num7;
								array2[num4] = (byte)(num10 & 255U);
								array2[num4 + 1] = (byte)((num10 & 65280U) >> 8);
								array2[num4 + 2] = (byte)((num10 & 16711680U) >> 16);
								array2[num4 + 3] = (byte)((num10 & 4278190080U) >> 24);
							}
						}
						array = array2;
						int num11 = array.Length / 8;
						Class6.Class9 @class = new Class6.Class9(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = @class.method_3();
							int value = @class.method_3();
							dictionary.Add(key, value);
						}
						@class.method_4();
					}
					Class6.dictionary_0 = dictionary;
				}
			}
			foreach (FieldInfo fieldInfo in typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField))
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = Class6.dictionary_0[metadataToken];
				bool flag2 = (num12 & 1073741824) > 0;
				num12 &= 1073741823;
				MethodInfo methodInfo = (MethodInfo)typeof(Class6).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
				if (methodInfo.IsStatic)
				{
					fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
				}
				else
				{
					ParameterInfo[] parameters = methodInfo.GetParameters();
					int num13 = parameters.Length + 1;
					Type[] array3 = new Type[num13];
					if (methodInfo.DeclaringType.IsValueType)
					{
						array3[0] = methodInfo.DeclaringType.MakeByRefType();
					}
					else
					{
						array3[0] = typeof(object);
					}
					for (int n = 0; n < parameters.Length; n++)
					{
						array3[n + 1] = parameters[n].ParameterType;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					for (int num14 = 0; num14 < num13; num14++)
					{
						switch (num14)
						{
						case 0:
							ilgenerator.Emit(OpCodes.Ldarg_0);
							break;
						case 1:
							ilgenerator.Emit(OpCodes.Ldarg_1);
							break;
						case 2:
							ilgenerator.Emit(OpCodes.Ldarg_2);
							break;
						case 3:
							ilgenerator.Emit(OpCodes.Ldarg_3);
							break;
						default:
							ilgenerator.Emit(OpCodes.Ldarg_S, num14);
							break;
						}
					}
					ilgenerator.Emit(OpCodes.Tailcall);
					ilgenerator.Emit(flag2 ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
					ilgenerator.Emit(OpCodes.Ret);
					fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	// Token: 0x06000060 RID: 96 RVA: 0x0001E32B File Offset: 0x00017B2B
	private static uint smethod_11(uint uint_1)
	{
		return 25U;
	}

	// Token: 0x06000061 RID: 97 RVA: 0x0001E0CF File Offset: 0x000178CF
	internal static void smethod_12()
	{
	}

	// Token: 0x06000062 RID: 98 RVA: 0x000202FC File Offset: 0x00019AFC
	[Class6.Attribute0(typeof(Class6.Attribute0.Class7<object>[]))]
	internal static string smethod_13(int int_5)
	{
		if (Class6.byte_3.Length == 0)
		{
			Class6.Class9 @class = new Class6.Class9(Class6.assembly_0.GetManifestResourceStream("BdnS3Eb5fe5QIt5dbI.LATx84wc473tVoMCto"));
			@class.method_0().Position = 0L;
			byte[] array = @class.method_1((int)@class.method_0().Length);
			@class.method_4();
			byte[] array2 = new byte[32];
			array2[0] = 122;
			array2[0] = 112;
			array2[0] = 157;
			array2[0] = 34;
			array2[0] = 157;
			array2[0] = 55;
			array2[1] = 86;
			array2[1] = 132;
			array2[1] = 132;
			array2[1] = 105;
			array2[1] = 73;
			array2[1] = 149;
			array2[2] = 124;
			array2[2] = 63;
			array2[2] = 96;
			array2[2] = 72;
			array2[2] = 92;
			array2[3] = 124;
			array2[3] = 136;
			array2[3] = 130;
			array2[3] = 56;
			array2[3] = 151;
			array2[4] = 151;
			array2[4] = 129;
			array2[4] = 117;
			array2[4] = 90;
			array2[4] = 153;
			array2[4] = 47;
			array2[5] = 113;
			array2[5] = 170;
			array2[5] = 92;
			array2[5] = 114;
			array2[5] = 206;
			array2[6] = 63;
			array2[6] = 132;
			array2[6] = 81;
			array2[6] = 153;
			array2[6] = 39;
			array2[6] = 224;
			array2[7] = 138;
			array2[7] = 117;
			array2[7] = 20;
			array2[8] = 117;
			array2[8] = 109;
			array2[8] = 154;
			array2[8] = 136;
			array2[8] = 116;
			array2[8] = 253;
			array2[9] = 148;
			array2[9] = 37;
			array2[9] = 121;
			array2[10] = 209;
			array2[10] = 187;
			array2[10] = 164;
			array2[10] = 92;
			array2[10] = 62;
			array2[11] = 236;
			array2[11] = 19;
			array2[11] = 98;
			array2[11] = 141;
			array2[11] = 138;
			array2[12] = 150;
			array2[12] = 124;
			array2[12] = 80;
			array2[13] = 107;
			array2[13] = 147;
			array2[13] = 166;
			array2[13] = 157;
			array2[13] = 118;
			array2[13] = 249;
			array2[14] = 130;
			array2[14] = 136;
			array2[14] = 118;
			array2[15] = 101;
			array2[15] = 124;
			array2[15] = 99;
			array2[15] = 221;
			array2[15] = 132;
			array2[15] = 122;
			array2[16] = 164;
			array2[16] = 138;
			array2[16] = 131;
			array2[16] = 33;
			array2[16] = 96;
			array2[16] = 0;
			array2[17] = 49;
			array2[17] = 114;
			array2[17] = 171;
			array2[17] = 51;
			array2[18] = 203;
			array2[18] = 80;
			array2[18] = 117;
			array2[18] = 172;
			array2[18] = 217;
			array2[19] = 106;
			array2[19] = 160;
			array2[19] = 48;
			array2[20] = 86;
			array2[20] = 149;
			array2[20] = 7;
			array2[21] = 86;
			array2[21] = 180;
			array2[21] = 84;
			array2[22] = 160;
			array2[22] = 33;
			array2[22] = 142;
			array2[22] = 172;
			array2[22] = 174;
			array2[23] = 62;
			array2[23] = 149;
			array2[23] = 88;
			array2[23] = 115;
			array2[23] = 170;
			array2[23] = 146;
			array2[24] = 71;
			array2[24] = 44;
			array2[24] = 62;
			array2[24] = 249;
			array2[25] = 118;
			array2[25] = 118;
			array2[25] = 101;
			array2[25] = 73;
			array2[25] = 120;
			array2[26] = 116;
			array2[26] = 184;
			array2[26] = 86;
			array2[27] = 61;
			array2[27] = 81;
			array2[27] = 150;
			array2[27] = 167;
			array2[27] = 211;
			array2[28] = 74;
			array2[28] = 144;
			array2[28] = 168;
			array2[28] = 139;
			array2[28] = 220;
			array2[29] = 96;
			array2[29] = 149;
			array2[29] = 3;
			array2[30] = 73;
			array2[30] = 84;
			array2[30] = 96;
			array2[30] = 170;
			array2[30] = 155;
			array2[31] = 77;
			array2[31] = 117;
			array2[31] = 205;
			byte[] array3 = array2;
			byte[] array4 = new byte[16];
			array4[0] = 122;
			array4[0] = 112;
			array4[0] = 173;
			array4[1] = 32;
			array4[1] = 197;
			array4[1] = 102;
			array4[1] = 251;
			array4[2] = 2;
			array4[2] = 90;
			array4[2] = 101;
			array4[3] = 109;
			array4[3] = 102;
			array4[3] = 74;
			array4[4] = 167;
			array4[4] = 95;
			array4[4] = 37;
			array4[5] = 158;
			array4[5] = 114;
			array4[5] = 122;
			array4[5] = 124;
			array4[5] = 143;
			array4[6] = 87;
			array4[6] = 60;
			array4[6] = 168;
			array4[6] = 156;
			array4[6] = 111;
			array4[6] = 197;
			array4[7] = 117;
			array4[7] = 80;
			array4[7] = 132;
			array4[7] = 113;
			array4[7] = 77;
			array4[8] = 92;
			array4[8] = 114;
			array4[8] = 107;
			array4[8] = 239;
			array4[9] = 132;
			array4[9] = 107;
			array4[9] = 217;
			array4[10] = 186;
			array4[10] = 98;
			array4[10] = 70;
			array4[11] = 111;
			array4[11] = 165;
			array4[11] = 152;
			array4[11] = 242;
			array4[12] = 122;
			array4[12] = 160;
			array4[12] = 168;
			array4[12] = 71;
			array4[12] = 83;
			array4[13] = 154;
			array4[13] = 103;
			array4[13] = 94;
			array4[13] = 213;
			array4[13] = 33;
			array4[14] = 183;
			array4[14] = 104;
			array4[14] = 210;
			array4[15] = 120;
			array4[15] = 113;
			array4[15] = 237;
			array4[15] = 169;
			byte[] array5 = array4;
			Array.Reverse(array5);
			byte[] publicKeyToken = Class6.assembly_0.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length != 0)
			{
				array5[1] = publicKeyToken[0];
				array5[3] = publicKeyToken[1];
				array5[5] = publicKeyToken[2];
				array5[7] = publicKeyToken[3];
				array5[9] = publicKeyToken[4];
				array5[11] = publicKeyToken[5];
				array5[13] = publicKeyToken[6];
				array5[15] = publicKeyToken[7];
			}
			for (int i = 0; i < array5.Length; i++)
			{
				array3[i] ^= array5[i];
			}
			if (int_5 == -1)
			{
				SymmetricAlgorithm symmetricAlgorithm = Class6.smethod_7();
				symmetricAlgorithm.Mode = CipherMode.CBC;
				ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array3, array5);
				Stream stream = Class6.smethod_25();
				CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				Class6.byte_3 = Class6.smethod_26(stream);
				stream.Close();
				cryptoStream.Close();
				array = Class6.byte_3;
			}
			int num = array.Length % 4;
			int num2 = array.Length / 4;
			byte[] array6 = new byte[array.Length];
			int num3 = array3.Length / 4;
			uint num4 = 0U;
			if (num > 0)
			{
				num2++;
			}
			for (int j = 0; j < num2; j++)
			{
				int num5 = j % num3;
				int num6 = j * 4;
				uint num7 = (uint)(num5 * 4);
				uint num8 = (uint)((int)array3[(int)(num7 + 3U)] << 24 | (int)array3[(int)(num7 + 2U)] << 16 | (int)array3[(int)(num7 + 1U)] << 8 | (int)array3[(int)num7]);
				uint num9 = 255U;
				int num10 = 0;
				uint num11;
				if (j == num2 - 1 && num > 0)
				{
					num11 = 0U;
					num4 += num8;
					for (int k = 0; k < num; k++)
					{
						if (k > 0)
						{
							num11 <<= 8;
						}
						num11 |= (uint)array[array.Length - (1 + k)];
					}
				}
				else
				{
					num4 += num8;
					num7 = (uint)num6;
					num11 = (uint)((int)array[(int)(num7 + 3U)] << 24 | (int)array[(int)(num7 + 2U)] << 16 | (int)array[(int)(num7 + 1U)] << 8 | (int)array[(int)num7]);
				}
				uint num13;
				uint num12 = num13 = num4;
				num13 ^= num13 >> 7;
				num13 += 308862330U;
				num13 ^= num13 << 1;
				num13 += 181045965U;
				num13 ^= num13 >> 18;
				num13 += 1647792453U;
				num13 = 3875551447U + num13;
				num4 = num12 + (uint)num13;
				if (j == num2 - 1 && num > 0)
				{
					uint num14 = num4 ^ num11;
					for (int l = 0; l < num; l++)
					{
						if (l > 0)
						{
							num9 <<= 8;
							num10 += 8;
						}
						array6[num6 + l] = (byte)((num14 & num9) >> num10);
					}
				}
				else
				{
					uint num15 = num4 ^ num11;
					array6[num6] = (byte)(num15 & 255U);
					array6[num6 + 1] = (byte)((num15 & 65280U) >> 8);
					array6[num6 + 2] = (byte)((num15 & 16711680U) >> 16);
					array6[num6 + 3] = (byte)((num15 & 4278190080U) >> 24);
				}
			}
			Class6.byte_3 = array6;
		}
		int count = BitConverter.ToInt32(Class6.byte_3, int_5);
		try
		{
			return Encoding.Unicode.GetString(Class6.byte_3, int_5 + 4, count);
		}
		catch
		{
		}
		return "";
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00020F30 File Offset: 0x0001A730
	[Class6.Attribute0(typeof(Class6.Attribute0.Class7<object>[]))]
	internal static string smethod_14(string string_1)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00020F60 File Offset: 0x0001A760
	private static void sBkIkClujw()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00020F88 File Offset: 0x0001A788
	private static Delegate smethod_15(IntPtr intptr_4, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[]
		{
			intptr_4,
			type_0
		});
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00020FE8 File Offset: 0x0001A7E8
	internal static object smethod_16(Assembly assembly_1)
	{
		try
		{
			if (File.Exists(((Assembly)assembly_1).Location))
			{
				return ((Assembly)assembly_1).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)assembly_1).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)assembly_1).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0]).ToString()))
			{
				return assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0]).ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	// Token: 0x06000067 RID: 103
	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_1);

	// Token: 0x06000068 RID: 104
	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_4, string string_1);

	// Token: 0x06000069 RID: 105 RVA: 0x000210F8 File Offset: 0x0001A8F8
	private static IntPtr smethod_17(IntPtr intptr_4, string string_1, uint uint_1)
	{
		if (Class6.delegate4_0 == null)
		{
			Class6.delegate4_0 = (Class6.Delegate4)Marshal.GetDelegateForFunctionPointer(Class6.GetProcAddress(Class6.smethod_23(), "Find ".Trim() + "ResourceA"), typeof(Class6.Delegate4));
		}
		return Class6.delegate4_0(intptr_4, string_1, uint_1);
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00021150 File Offset: 0x0001A950
	private static IntPtr smethod_18(IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3)
	{
		if (Class6.delegate5_0 == null)
		{
			Class6.delegate5_0 = (Class6.Delegate5)Marshal.GetDelegateForFunctionPointer(Class6.GetProcAddress(Class6.smethod_23(), "Virtual ".Trim() + "Alloc"), typeof(Class6.Delegate5));
		}
		return Class6.delegate5_0(intptr_4, uint_1, uint_2, uint_3);
	}

	// Token: 0x0600006B RID: 107 RVA: 0x000211AC File Offset: 0x0001A9AC
	private static int smethod_19(IntPtr intptr_4, IntPtr intptr_5, [In] [Out] byte[] byte_4, uint uint_1, out IntPtr intptr_6)
	{
		if (Class6.delegate6_0 == null)
		{
			Class6.delegate6_0 = (Class6.Delegate6)Marshal.GetDelegateForFunctionPointer(Class6.GetProcAddress(Class6.smethod_23(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(Class6.Delegate6));
		}
		return Class6.delegate6_0(intptr_4, intptr_5, byte_4, uint_1, out intptr_6);
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00021214 File Offset: 0x0001AA14
	private static int smethod_20(IntPtr intptr_4, int int_5, int int_6, ref int int_7)
	{
		if (Class6.delegate7_0 == null)
		{
			Class6.delegate7_0 = (Class6.Delegate7)Marshal.GetDelegateForFunctionPointer(Class6.GetProcAddress(Class6.smethod_23(), "Virtual ".Trim() + "Protect"), typeof(Class6.Delegate7));
		}
		return Class6.delegate7_0(intptr_4, int_5, int_6, ref int_7);
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00021270 File Offset: 0x0001AA70
	private static IntPtr smethod_21(uint uint_1, int int_5, uint uint_2)
	{
		if (Class6.delegate8_0 == null)
		{
			Class6.delegate8_0 = (Class6.Delegate8)Marshal.GetDelegateForFunctionPointer(Class6.GetProcAddress(Class6.smethod_23(), "Open ".Trim() + "Process"), typeof(Class6.Delegate8));
		}
		return Class6.delegate8_0(uint_1, int_5, uint_2);
	}

	// Token: 0x0600006E RID: 110 RVA: 0x000212C8 File Offset: 0x0001AAC8
	private static int smethod_22(IntPtr intptr_4)
	{
		if (Class6.delegate9_0 == null)
		{
			Class6.delegate9_0 = (Class6.Delegate9)Marshal.GetDelegateForFunctionPointer(Class6.GetProcAddress(Class6.smethod_23(), "Close ".Trim() + "Handle"), typeof(Class6.Delegate9));
		}
		return Class6.delegate9_0(intptr_4);
	}

	// Token: 0x0600006F RID: 111 RVA: 0x0001E332 File Offset: 0x00017B32
	private static IntPtr smethod_23()
	{
		if (Class6.intptr_2 == IntPtr.Zero)
		{
			Class6.intptr_2 = Class6.LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return Class6.intptr_2;
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00021320 File Offset: 0x0001AB20
	[Class6.Attribute0(typeof(Class6.Attribute0.Class7<object>[]))]
	private static byte[] smethod_24(string string_1)
	{
		byte[] array;
		using (FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			int num = 0;
			int i = (int)fileStream.Length;
			array = new byte[i];
			while (i > 0)
			{
				int num2 = fileStream.Read(array, num, i);
				num += num2;
				i -= num2;
			}
		}
		return array;
	}

	// Token: 0x06000071 RID: 113 RVA: 0x0001E368 File Offset: 0x00017B68
	private static Stream smethod_25()
	{
		return new MemoryStream();
	}

	// Token: 0x06000072 RID: 114 RVA: 0x0001E36F File Offset: 0x00017B6F
	private static byte[] smethod_26(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00021380 File Offset: 0x0001AB80
	[Class6.Attribute0(typeof(Class6.Attribute0.Class7<object>[]))]
	private static byte[] smethod_27(byte[] byte_4)
	{
		Stream stream = Class6.smethod_25();
		SymmetricAlgorithm symmetricAlgorithm = Class6.smethod_7();
		symmetricAlgorithm.Key = new byte[]
		{
			41,
			115,
			119,
			141,
			196,
			190,
			105,
			241,
			193,
			177,
			32,
			210,
			111,
			11,
			80,
			49,
			44,
			135,
			176,
			182,
			254,
			192,
			148,
			249,
			119,
			137,
			92,
			161,
			25,
			56,
			25,
			128
		};
		symmetricAlgorithm.IV = new byte[]
		{
			163,
			148,
			218,
			213,
			134,
			242,
			152,
			51,
			53,
			177,
			108,
			40,
			35,
			101,
			152,
			206
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_4, 0, byte_4.Length);
		cryptoStream.Close();
		return Class6.smethod_26(stream);
	}

	// Token: 0x06000074 RID: 116 RVA: 0x0001E37C File Offset: 0x00017B7C
	private byte[] method_0()
	{
		return null;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x0001E37C File Offset: 0x00017B7C
	private byte[] method_1()
	{
		return null;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x0001E37F File Offset: 0x00017B7F
	private byte[] method_2()
	{
		int length = "{11111-22222-20001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x06000077 RID: 119 RVA: 0x0001E39A File Offset: 0x00017B9A
	private byte[] method_3()
	{
		int length = "{11111-22222-20001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x06000078 RID: 120 RVA: 0x0001E3B5 File Offset: 0x00017BB5
	private byte[] method_4()
	{
		int length = "{11111-22222-30001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x06000079 RID: 121 RVA: 0x0001E3D0 File Offset: 0x00017BD0
	private byte[] method_5()
	{
		int length = "{11111-22222-30001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600007A RID: 122 RVA: 0x0001E3EB File Offset: 0x00017BEB
	internal byte[] method_6()
	{
		int length = "{11111-22222-40001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600007B RID: 123 RVA: 0x0001E406 File Offset: 0x00017C06
	internal byte[] method_7()
	{
		int length = "{11111-22222-40001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600007C RID: 124 RVA: 0x0001E37C File Offset: 0x00017B7C
	internal byte[] method_8()
	{
		return null;
	}

	// Token: 0x0600007D RID: 125 RVA: 0x0001E37C File Offset: 0x00017B7C
	internal byte[] method_9()
	{
		return null;
	}

	// Token: 0x0600007F RID: 127 RVA: 0x0001E429 File Offset: 0x00017C29
	internal static bool DFlAcWHh9plcyBCEL0()
	{
		return null == null;
	}

	// Token: 0x0400002D RID: 45
	private static bool bool_0;

	// Token: 0x0400002E RID: 46
	private static byte[] byte_0;

	// Token: 0x0400002F RID: 47
	private static Dictionary<int, int> dictionary_0;

	// Token: 0x04000030 RID: 48
	private static byte[] byte_1;

	// Token: 0x04000031 RID: 49
	private static bool bool_1;

	// Token: 0x04000032 RID: 50
	internal static Class6.Delegate2 delegate2_0;

	// Token: 0x04000033 RID: 51
	private static long long_0;

	// Token: 0x04000034 RID: 52
	[Class6.Attribute0(typeof(Class6.Attribute0.Class7<object>[]))]
	private static bool bool_2;

	// Token: 0x04000035 RID: 53
	internal static Hashtable hashtable_0;

	// Token: 0x04000036 RID: 54
	private static Class6.Delegate4 delegate4_0;

	// Token: 0x04000037 RID: 55
	private static Class6.Delegate7 delegate7_0;

	// Token: 0x04000038 RID: 56
	private static int[] int_0;

	// Token: 0x04000039 RID: 57
	private static Class6.Delegate9 delegate9_0;

	// Token: 0x0400003A RID: 58
	private static Assembly assembly_0;

	// Token: 0x0400003B RID: 59
	private static IntPtr intptr_0;

	// Token: 0x0400003C RID: 60
	private static bool bool_3;

	// Token: 0x0400003D RID: 61
	private static int int_1;

	// Token: 0x0400003E RID: 62
	private static bool bool_4;

	// Token: 0x0400003F RID: 63
	private static IntPtr intptr_1;

	// Token: 0x04000040 RID: 64
	private static int int_2;

	// Token: 0x04000041 RID: 65
	private static int int_3;

	// Token: 0x04000042 RID: 66
	private static bool bool_5;

	// Token: 0x04000043 RID: 67
	private static uint[] uint_0;

	// Token: 0x04000044 RID: 68
	private static int int_4;

	// Token: 0x04000045 RID: 69
	private static IntPtr intptr_2;

	// Token: 0x04000046 RID: 70
	private static byte[] byte_2;

	// Token: 0x04000047 RID: 71
	private static IntPtr intptr_3;

	// Token: 0x04000048 RID: 72
	private static Class6.Delegate5 delegate5_0;

	// Token: 0x04000049 RID: 73
	private static long long_1;

	// Token: 0x0400004A RID: 74
	private static Class6.Delegate8 delegate8_0;

	// Token: 0x0400004B RID: 75
	internal static Class6.Delegate2 delegate2_1;

	// Token: 0x0400004C RID: 76
	private static Class6.Delegate6 delegate6_0;

	// Token: 0x0400004D RID: 77
	private static string[] string_0;

	// Token: 0x0400004E RID: 78
	private static bool bool_6;

	// Token: 0x0400004F RID: 79
	private static object fFbIlVunGp;

	// Token: 0x04000050 RID: 80
	private static SortedList sortedList_0;

	// Token: 0x04000051 RID: 81
	private static byte[] byte_3;

	// Token: 0x02000014 RID: 20
	private sealed class Delegate1 : MulticastDelegate
	{
		// Token: 0x06000080 RID: 128
		public extern Delegate1(object object_0, IntPtr intptr_0);

		// Token: 0x06000081 RID: 129
		public extern void Invoke(object o);

		// Token: 0x06000082 RID: 130
		public extern IAsyncResult BeginInvoke(object o, AsyncCallback callback, object @object);

		// Token: 0x06000083 RID: 131
		public extern void EndInvoke(IAsyncResult result);

		// Token: 0x06000084 RID: 132 RVA: 0x0001E048 File Offset: 0x00017848
		static Delegate1()
		{
			Class11.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	// Token: 0x02000015 RID: 21
	internal class Attribute0 : Attribute
	{
		// Token: 0x06000085 RID: 133 RVA: 0x0001E42F File Offset: 0x00017C2F
		[Class6.Attribute0(typeof(Class6.Attribute0.Class7<object>[]))]
		public Attribute0(object object_0)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0001E048 File Offset: 0x00017848
		// Note: this type is marked as 'beforefieldinit'.
		static Attribute0()
		{
			Class11.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x02000016 RID: 22
		internal class Class7<hyBoLgRgPeXX2j1bwo>
		{
			// Token: 0x06000087 RID: 135 RVA: 0x0001E0AE File Offset: 0x000178AE
			public Class7()
			{
				Class10.mLqA1qsz6sJ2l();
				base..ctor();
			}

			// Token: 0x06000088 RID: 136 RVA: 0x0001E048 File Offset: 0x00017848
			// Note: this type is marked as 'beforefieldinit'.
			static Class7()
			{
				Class11.kLjw4iIsCLsZtxc4lksN0j();
			}
		}
	}

	// Token: 0x02000017 RID: 23
	internal class Class8
	{
		// Token: 0x06000089 RID: 137 RVA: 0x000213EC File Offset: 0x0001ABEC
		[Class6.Attribute0(typeof(Class6.Attribute0.Class7<object>[]))]
		internal static string smethod_0(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] key = new byte[]
			{
				82,
				102,
				104,
				110,
				32,
				77,
				24,
				34,
				118,
				181,
				51,
				17,
				18,
				51,
				12,
				109,
				10,
				32,
				77,
				24,
				34,
				158,
				161,
				41,
				97,
				28,
				118,
				181,
				5,
				25,
				1,
				88
			};
			byte[] iv = Class6.smethod_9(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Class6.smethod_7();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iv;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0001E048 File Offset: 0x00017848
		// Note: this type is marked as 'beforefieldinit'.
		static Class8()
		{
			Class11.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	// Token: 0x02000018 RID: 24
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal sealed class Delegate2 : MulticastDelegate
	{
		// Token: 0x0600008C RID: 140
		public extern Delegate2(object object_0, IntPtr intptr_0);

		// Token: 0x0600008D RID: 141
		public extern uint Invoke(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

		// Token: 0x0600008E RID: 142
		public extern IAsyncResult BeginInvoke(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode, AsyncCallback callback, object @object);

		// Token: 0x0600008F RID: 143
		public extern uint EndInvoke(ref uint nativeSizeOfCode, IAsyncResult result);

		// Token: 0x06000090 RID: 144 RVA: 0x0001E048 File Offset: 0x00017848
		static Delegate2()
		{
			Class11.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	// Token: 0x02000019 RID: 25
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private sealed class Delegate3 : MulticastDelegate
	{
		// Token: 0x06000091 RID: 145
		public extern Delegate3(object object_0, IntPtr intptr_0);

		// Token: 0x06000092 RID: 146
		public extern IntPtr Invoke();

		// Token: 0x06000093 RID: 147
		public extern IAsyncResult BeginInvoke(AsyncCallback callback, object @object);

		// Token: 0x06000094 RID: 148
		public extern IntPtr EndInvoke(IAsyncResult result);

		// Token: 0x06000095 RID: 149 RVA: 0x0001E048 File Offset: 0x00017848
		static Delegate3()
		{
			Class11.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	// Token: 0x0200001A RID: 26
	internal struct Struct0
	{
		// Token: 0x04000052 RID: 82
		internal bool bool_0;

		// Token: 0x04000053 RID: 83
		internal byte[] byte_0;
	}

	// Token: 0x0200001B RID: 27
	internal class Class9
	{
		// Token: 0x06000096 RID: 150 RVA: 0x0001E437 File Offset: 0x00017C37
		public Class9(Stream stream_0)
		{
			this.binaryReader_0 = new BinaryReader(stream_0);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0001E44B File Offset: 0x00017C4B
		internal Stream method_0()
		{
			return this.binaryReader_0.BaseStream;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0001E458 File Offset: 0x00017C58
		internal byte[] method_1(int int_0)
		{
			return this.binaryReader_0.ReadBytes(int_0);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0001E466 File Offset: 0x00017C66
		internal int method_2(byte[] byte_0, int int_0, int int_1)
		{
			return this.binaryReader_0.Read(byte_0, int_0, int_1);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0001E476 File Offset: 0x00017C76
		internal int method_3()
		{
			return this.binaryReader_0.ReadInt32();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0001E483 File Offset: 0x00017C83
		internal void method_4()
		{
			this.binaryReader_0.Close();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0001E048 File Offset: 0x00017848
		// Note: this type is marked as 'beforefieldinit'.
		static Class9()
		{
			Class11.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x04000054 RID: 84
		private BinaryReader binaryReader_0;
	}

	// Token: 0x0200001C RID: 28
	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private sealed class Delegate4 : MulticastDelegate
	{
		// Token: 0x0600009D RID: 157
		public extern Delegate4(object object_0, IntPtr intptr_0);

		// Token: 0x0600009E RID: 158
		public extern IntPtr Invoke(IntPtr hModule, string lpName, uint lpType);

		// Token: 0x0600009F RID: 159
		public extern IAsyncResult BeginInvoke(IntPtr hModule, string lpName, uint lpType, AsyncCallback callback, object @object);

		// Token: 0x060000A0 RID: 160
		public extern IntPtr EndInvoke(IAsyncResult result);

		// Token: 0x060000A1 RID: 161 RVA: 0x0001E048 File Offset: 0x00017848
		static Delegate4()
		{
			Class11.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	// Token: 0x0200001D RID: 29
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private sealed class Delegate5 : MulticastDelegate
	{
		// Token: 0x060000A2 RID: 162
		public extern Delegate5(object object_0, IntPtr intptr_0);

		// Token: 0x060000A3 RID: 163
		public extern IntPtr Invoke(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		// Token: 0x060000A4 RID: 164
		public extern IAsyncResult BeginInvoke(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect, AsyncCallback callback, object @object);

		// Token: 0x060000A5 RID: 165
		public extern IntPtr EndInvoke(IAsyncResult result);

		// Token: 0x060000A6 RID: 166 RVA: 0x0001E048 File Offset: 0x00017848
		static Delegate5()
		{
			Class11.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	// Token: 0x0200001E RID: 30
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private sealed class Delegate6 : MulticastDelegate
	{
		// Token: 0x060000A7 RID: 167
		public extern Delegate6(object object_0, IntPtr intptr_0);

		// Token: 0x060000A8 RID: 168
		public extern int Invoke(IntPtr hProcess, IntPtr lpBaseAddress, [In] [Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

		// Token: 0x060000A9 RID: 169
		public extern IAsyncResult BeginInvoke(IntPtr hProcess, IntPtr lpBaseAddress, [In] [Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten, AsyncCallback callback, object @object);

		// Token: 0x060000AA RID: 170
		public extern int EndInvoke(out IntPtr lpNumberOfBytesWritten, IAsyncResult result);

		// Token: 0x060000AB RID: 171 RVA: 0x0001E048 File Offset: 0x00017848
		static Delegate6()
		{
			Class11.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	// Token: 0x0200001F RID: 31
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private sealed class Delegate7 : MulticastDelegate
	{
		// Token: 0x060000AC RID: 172
		public extern Delegate7(object object_0, IntPtr intptr_0);

		// Token: 0x060000AD RID: 173
		public extern int Invoke(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

		// Token: 0x060000AE RID: 174
		public extern IAsyncResult BeginInvoke(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect, AsyncCallback callback, object @object);

		// Token: 0x060000AF RID: 175
		public extern int EndInvoke(ref int lpflOldProtect, IAsyncResult result);

		// Token: 0x060000B0 RID: 176 RVA: 0x0001E048 File Offset: 0x00017848
		static Delegate7()
		{
			Class11.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	// Token: 0x02000020 RID: 32
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private sealed class Delegate8 : MulticastDelegate
	{
		// Token: 0x060000B1 RID: 177
		public extern Delegate8(object object_0, IntPtr intptr_0);

		// Token: 0x060000B2 RID: 178
		public extern IntPtr Invoke(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

		// Token: 0x060000B3 RID: 179
		public extern IAsyncResult BeginInvoke(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId, AsyncCallback callback, object @object);

		// Token: 0x060000B4 RID: 180
		public extern IntPtr EndInvoke(IAsyncResult result);

		// Token: 0x060000B5 RID: 181 RVA: 0x0001E048 File Offset: 0x00017848
		static Delegate8()
		{
			Class11.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	// Token: 0x02000021 RID: 33
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private sealed class Delegate9 : MulticastDelegate
	{
		// Token: 0x060000B6 RID: 182
		public extern Delegate9(object object_0, IntPtr intptr_0);

		// Token: 0x060000B7 RID: 183
		public extern int Invoke(IntPtr ptr);

		// Token: 0x060000B8 RID: 184
		public extern IAsyncResult BeginInvoke(IntPtr ptr, AsyncCallback callback, object @object);

		// Token: 0x060000B9 RID: 185
		public extern int EndInvoke(IAsyncResult result);

		// Token: 0x060000BA RID: 186 RVA: 0x0001E048 File Offset: 0x00017848
		static Delegate9()
		{
			Class11.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	// Token: 0x02000022 RID: 34
	[Flags]
	private enum Enum0
	{

	}
}
