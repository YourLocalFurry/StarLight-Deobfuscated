using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

// Token: 0x02000024 RID: 36
internal class Class11
{
	// Token: 0x060000BE RID: 190 RVA: 0x0002146C File Offset: 0x0001AC6C
	private static void smethod_0()
	{
		if (!Class11.bool_0)
		{
			Class6.Class9 @class = new Class6.Class9(typeof(Class11).Assembly.GetManifestResourceStream("N2avsn1wRIPVpABBpw.nIWlmtBqSsuhI0ybTS"));
			@class.method_0().Position = 0L;
			byte[] array = @class.method_1((int)@class.method_0().Length);
			byte[] array2 = new byte[32];
			array2[0] = 151;
			array2[0] = 149;
			array2[0] = 22;
			array2[1] = 94;
			array2[1] = 141;
			array2[1] = 88;
			array2[2] = 121;
			array2[2] = 131;
			array2[2] = 106;
			array2[3] = 166;
			array2[3] = 85;
			array2[3] = 175;
			array2[4] = 120;
			array2[4] = 134;
			array2[4] = 105;
			array2[5] = 125;
			array2[5] = 160;
			array2[5] = 152;
			array2[5] = 149;
			array2[5] = 150;
			array2[6] = 169;
			array2[6] = 130;
			array2[6] = 215;
			array2[6] = 138;
			array2[7] = 162;
			array2[7] = 159;
			array2[7] = 114;
			array2[7] = 154;
			array2[8] = 101;
			array2[8] = 108;
			array2[8] = 172;
			array2[9] = 169;
			array2[9] = 208;
			array2[9] = 143;
			array2[9] = 129;
			array2[9] = 211;
			array2[10] = 157;
			array2[10] = 127;
			array2[10] = 105;
			array2[10] = 247;
			array2[11] = 148;
			array2[11] = 122;
			array2[11] = 121;
			array2[11] = 237;
			array2[12] = 147;
			array2[12] = 167;
			array2[12] = 104;
			array2[12] = 169;
			array2[13] = 109;
			array2[13] = 106;
			array2[13] = 106;
			array2[13] = 98;
			array2[13] = 151;
			array2[13] = 139;
			array2[14] = 109;
			array2[14] = 123;
			array2[14] = 30;
			array2[15] = 90;
			array2[15] = 102;
			array2[15] = 106;
			array2[15] = 107;
			array2[15] = 142;
			array2[15] = 254;
			array2[16] = 117;
			array2[16] = 86;
			array2[16] = 106;
			array2[16] = 93;
			array2[16] = 12;
			array2[17] = 194;
			array2[17] = 40;
			array2[17] = 159;
			array2[17] = 148;
			array2[17] = 213;
			array2[18] = 95;
			array2[18] = 174;
			array2[18] = 160;
			array2[18] = 22;
			array2[19] = 124;
			array2[19] = 119;
			array2[19] = 37;
			array2[20] = 139;
			array2[20] = 158;
			array2[20] = 51;
			array2[21] = 120;
			array2[21] = 99;
			array2[21] = 236;
			array2[22] = 112;
			array2[22] = 155;
			array2[22] = 86;
			array2[22] = 137;
			array2[23] = 154;
			array2[23] = 170;
			array2[23] = 179;
			array2[23] = 85;
			array2[23] = 124;
			array2[23] = 69;
			array2[24] = 132;
			array2[24] = 170;
			array2[24] = 142;
			array2[24] = 111;
			array2[24] = 120;
			array2[24] = 83;
			array2[25] = 95;
			array2[25] = 103;
			array2[25] = 84;
			array2[25] = 142;
			array2[25] = 226;
			array2[26] = 217;
			array2[26] = 125;
			array2[26] = 151;
			array2[26] = 84;
			array2[26] = 63;
			array2[27] = 159;
			array2[27] = 148;
			array2[27] = 199;
			array2[28] = 104;
			array2[28] = 106;
			array2[28] = 60;
			array2[28] = 146;
			array2[28] = 90;
			array2[28] = 8;
			array2[29] = 112;
			array2[29] = 74;
			array2[29] = 37;
			array2[30] = 135;
			array2[30] = 79;
			array2[30] = 102;
			array2[30] = 47;
			array2[30] = 46;
			array2[31] = 152;
			array2[31] = 101;
			array2[31] = 178;
			byte[] array3 = array2;
			byte[] array4 = new byte[16];
			array4[0] = 94;
			array4[0] = 110;
			array4[0] = 135;
			array4[0] = 6;
			array4[1] = 116;
			array4[1] = 168;
			array4[1] = 119;
			array4[1] = 107;
			array4[1] = 235;
			array4[1] = 185;
			array4[2] = 164;
			array4[2] = 138;
			array4[2] = 65;
			array4[2] = 113;
			array4[3] = 120;
			array4[3] = 101;
			array4[3] = 177;
			array4[3] = 97;
			array4[3] = 61;
			array4[4] = 126;
			array4[4] = 150;
			array4[4] = 165;
			array4[4] = 72;
			array4[4] = 137;
			array4[4] = 24;
			array4[5] = 166;
			array4[5] = 182;
			array4[5] = 137;
			array4[5] = 94;
			array4[5] = 92;
			array4[5] = 23;
			array4[6] = 94;
			array4[6] = 144;
			array4[6] = 209;
			array4[6] = 71;
			array4[7] = 108;
			array4[7] = 146;
			array4[7] = 166;
			array4[7] = 126;
			array4[7] = 120;
			array4[7] = 216;
			array4[8] = 129;
			array4[8] = 165;
			array4[8] = 40;
			array4[8] = 41;
			array4[9] = 15;
			array4[9] = 80;
			array4[9] = 186;
			array4[10] = 145;
			array4[10] = 171;
			array4[10] = 113;
			array4[10] = 94;
			array4[10] = 47;
			array4[11] = 85;
			array4[11] = 40;
			array4[11] = 127;
			array4[11] = 87;
			array4[11] = 163;
			array4[11] = 178;
			array4[12] = 91;
			array4[12] = 122;
			array4[12] = 117;
			array4[12] = 139;
			array4[12] = 201;
			array4[13] = 158;
			array4[13] = 192;
			array4[13] = 157;
			array4[13] = 108;
			array4[13] = 107;
			array4[14] = 108;
			array4[14] = 117;
			array4[14] = 71;
			array4[14] = 110;
			array4[14] = 170;
			array4[15] = 144;
			array4[15] = 109;
			array4[15] = 154;
			array4[15] = 174;
			array4[15] = 127;
			byte[] array5 = array4;
			for (int i = 0; i < array5.Length; i++)
			{
				array3[i] ^= array5[i];
			}
			byte[] array6 = array;
			int num = array6.Length % 4;
			int num2 = array6.Length / 4;
			byte[] array7 = new byte[array6.Length];
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
						num11 |= (uint)array6[array6.Length - (1 + k)];
					}
				}
				else
				{
					num7 = (uint)num6;
					num4 += num8;
					num11 = (uint)((int)array6[(int)(num7 + 3U)] << 24 | (int)array6[(int)(num7 + 2U)] << 16 | (int)array6[(int)(num7 + 1U)] << 8 | (int)array6[(int)num7]);
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
						array7[num6 + l] = (byte)((num14 & num9) >> num10);
					}
				}
				else
				{
					uint num15 = num4 ^ num11;
					array7[num6] = (byte)(num15 & 255U);
					array7[num6 + 1] = (byte)((num15 & 65280U) >> 8);
					array7[num6 + 2] = (byte)((num15 & 16711680U) >> 16);
					array7[num6 + 3] = (byte)((num15 & 4278190080U) >> 24);
				}
			}
			Class11.object_0 = Class11.Class12.smethod_18(Class11.Class12.smethod_17(array7));
			Class11.string_0 = ((Assembly)Class11.object_0).GetManifestResourceNames();
			Class11.bool_0 = true;
		}
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00022084 File Offset: 0x0001B884
	internal static string[] smethod_1(Assembly assembly_0)
	{
		if (assembly_0 == typeof(Class11).Assembly)
		{
			if (!Class11.bool_0)
			{
				Class11.smethod_0();
			}
			List<string> list = new List<string>();
			list.AddRange(assembly_0.GetManifestResourceNames());
			list.AddRange(((Assembly)Class11.object_0).GetManifestResourceNames());
			return list.ToArray();
		}
		return assembly_0.GetManifestResourceNames();
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x000220E8 File Offset: 0x0001B8E8
	private static Assembly smethod_2(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		if (!Class11.bool_0)
		{
			Class11.smethod_0();
		}
		string name = resolveEventArgs_0.Name;
		for (int i = 0; i < Class11.string_0.Length; i++)
		{
			if (Class11.string_0[i] == name)
			{
				return (Assembly)Class11.object_0;
			}
		}
		return null;
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x0001E49F File Offset: 0x00017C9F
	public Class11()
	{
		AppDomain.CurrentDomain.ResourceResolve += Class11.smethod_2;
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x0001E4BD File Offset: 0x00017CBD
	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!Class11.bool_1)
		{
			Class11.bool_1 = true;
			new Class11();
		}
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x0001E429 File Offset: 0x00017C29
	internal static bool dopiNsaMQJC6wjvEpP()
	{
		return null == null;
	}

	// Token: 0x04000057 RID: 87
	private static string[] string_0 = new string[0];

	// Token: 0x04000058 RID: 88
	private static object object_0 = null;

	// Token: 0x04000059 RID: 89
	private static bool bool_0 = false;

	// Token: 0x0400005A RID: 90
	private static bool bool_1 = false;

	// Token: 0x02000025 RID: 37
	private enum Enum1
	{

	}

	// Token: 0x02000026 RID: 38
	internal class Class12
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00022138 File Offset: 0x0001B938
		private unsafe static uint smethod_0(void* pVoid_0, uint uint_0)
		{
			uint result = 0U;
			if (BitConverter.IsLittleEndian)
			{
				result = *(uint*)pVoid_0;
			}
			else
			{
				switch (uint_0)
				{
				case 1U:
					result = (uint)(*(byte*)pVoid_0);
					break;
				case 2U:
					result = (uint)((int)(*(byte*)pVoid_0) | (int)((byte*)pVoid_0)[1] << 8);
					break;
				case 3U:
					result = (uint)((int)(*(byte*)pVoid_0) | (int)((byte*)pVoid_0)[1] << 8 | (int)((byte*)pVoid_0)[2] << 16);
					break;
				case 4U:
					result = (uint)((int)(*(byte*)pVoid_0) | (int)((byte*)pVoid_0)[1] << 8 | (int)((byte*)pVoid_0)[2] << 16 | (int)((byte*)pVoid_0)[3] << 24);
					break;
				}
			}
			return result;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000221B0 File Offset: 0x0001B9B0
		private unsafe static void smethod_1(uint uint_0, void* pVoid_0, uint uint_1)
		{
			if (BitConverter.IsLittleEndian)
			{
				if (uint_1 == 1U)
				{
					*(byte*)pVoid_0 = (byte)uint_0;
					return;
				}
				if (uint_1 - 2U <= 2U)
				{
					*(int*)pVoid_0 = (int)uint_0;
					return;
				}
			}
			else
			{
				switch (uint_1)
				{
				case 1U:
					*(byte*)pVoid_0 = (byte)uint_0;
					break;
				case 2U:
					*(byte*)pVoid_0 = (byte)uint_0;
					((byte*)pVoid_0)[1] = (byte)(uint_0 >> 8);
					return;
				case 3U:
					*(byte*)pVoid_0 = (byte)uint_0;
					((byte*)pVoid_0)[1] = (byte)(uint_0 >> 8);
					((byte*)pVoid_0)[2] = (byte)(uint_0 >> 16);
					return;
				case 4U:
					*(byte*)pVoid_0 = (byte)uint_0;
					((byte*)pVoid_0)[1] = (byte)(uint_0 >> 8);
					((byte*)pVoid_0)[2] = (byte)(uint_0 >> 16);
					((byte*)pVoid_0)[3] = (byte)(uint_0 >> 24);
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00022238 File Offset: 0x0001BA38
		private unsafe static bool smethod_2(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
			bool flag = true;
			uint num = 0U;
			while (flag && num < uint_0)
			{
				flag = (((byte*)pVoid_0)[num] == ((byte*)pVoid_1)[num]);
				num += 1U;
			}
			return flag;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00022264 File Offset: 0x0001BA64
		private unsafe static bool smethod_3(void* pVoid_0, string string_0)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(string_0);
			byte[] array;
			byte* pVoid_;
			if ((array = bytes) != null && array.Length != 0)
			{
				pVoid_ = &array[0];
			}
			else
			{
				pVoid_ = null;
			}
			return Class11.Class12.smethod_2(pVoid_0, (void*)pVoid_, (uint)bytes.Length);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000222A0 File Offset: 0x0001BAA0
		private unsafe static void smethod_4(void* pVoid_0, byte byte_0, uint uint_0)
		{
			for (uint num = 0U; num < uint_0; num += 1U)
			{
				((byte*)pVoid_0)[num] = byte_0;
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000222C0 File Offset: 0x0001BAC0
		private unsafe static void smethod_5(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
			for (uint num = 0U; num < uint_0; num += 1U)
			{
				((byte*)pVoid_0)[num] = ((byte*)pVoid_1)[num];
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000222E4 File Offset: 0x0001BAE4
		private unsafe static void smethod_6(void* pVoid_0, string string_0)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(string_0);
			byte[] array;
			byte* pVoid_;
			if ((array = bytes) != null && array.Length != 0)
			{
				pVoid_ = &array[0];
			}
			else
			{
				pVoid_ = null;
			}
			Class11.Class12.smethod_5(pVoid_0, (void*)pVoid_, (uint)bytes.Length);
			array = null;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00022324 File Offset: 0x0001BB24
		private unsafe static void smethod_7(byte* pByte_0, byte* pByte_1, uint uint_0)
		{
			if (BitConverter.IsLittleEndian)
			{
				if (uint_0 < 5U)
				{
					*(int*)pByte_0 = (int)(*(uint*)pByte_1);
					return;
				}
				byte* ptr = pByte_0 + uint_0;
				while (pByte_0 < ptr)
				{
					*(int*)pByte_0 = (int)(*(uint*)pByte_1);
					pByte_0 += 4;
					pByte_1 += 4;
				}
				return;
			}
			else
			{
				if (uint_0 > 8U && pByte_1 + uint_0 < pByte_0)
				{
					Class11.Class12.smethod_5((void*)pByte_0, (void*)pByte_1, uint_0);
					return;
				}
				byte* ptr2 = pByte_0 + uint_0;
				while (pByte_0 < ptr2)
				{
					*pByte_0 = *pByte_1;
					pByte_0++;
					pByte_1++;
				}
				return;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00022388 File Offset: 0x0001BB88
		private unsafe static uint smethod_8(byte[] byte_0, uint uint_0, Class11.Enum1 enum1_0)
		{
			uint result = 0U;
			fixed (byte[] array = byte_0)
			{
				byte* ptr;
				if (byte_0 != null && array.Length != 0)
				{
					ptr = &array[0];
				}
				else
				{
					ptr = null;
				}
				if (Class11.Class12.smethod_3((void*)(ptr + uint_0), "QCLZ"))
				{
					result = *(uint*)(ptr + uint_0 + (IntPtr)enum1_0 * 4);
				}
			}
			return result;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0001E4F1 File Offset: 0x00017CF1
		private static uint smethod_9(byte[] byte_0)
		{
			return Class11.Class12.smethod_8(byte_0, 0U, (Class11.Enum1)2);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0001E4FB File Offset: 0x00017CFB
		public static uint smethod_10(byte[] byte_0, uint uint_0)
		{
			return Class11.Class12.smethod_8(byte_0, uint_0, (Class11.Enum1)3);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000223D0 File Offset: 0x0001BBD0
		private unsafe static uint smethod_11(byte[] byte_0, uint uint_0, byte[] byte_1, uint uint_1)
		{
			fixed (byte[] array = byte_0)
			{
				byte* ptr;
				if (byte_0 != null && array.Length != 0)
				{
					ptr = &array[0];
				}
				else
				{
					ptr = null;
				}
				fixed (byte[] array2 = byte_1)
				{
					byte* ptr2;
					if (byte_1 != null && array2.Length != 0)
					{
						ptr2 = &array2[0];
					}
					else
					{
						ptr2 = null;
					}
					byte* ptr3 = ptr + uint_0;
					uint num = 32U;
					byte* ptr4 = ptr3 + uint_1 - 1;
					byte* ptr5 = ptr3 + 1;
					byte** ptr6 = ptr2 + uint_1 + 36000 - sizeof(byte*) * 4096 - (ptr2 + uint_1) % 8L;
					byte* pVoid_ = ptr2 + 32;
					byte* ptr7 = ptr2 + 32 + 4 + 1;
					byte* ptr8 = ptr7;
					byte* ptr9 = ptr5;
					uint num2 = 1073741824U;
					uint* ptr10 = (uint*)ptr2;
					byte* ptr11 = ptr4 - 16;
					Class11.Class12.smethod_6((void*)ptr10, "QCLZ");
					*ptr2 = 81;
					ptr2[1] = 67;
					ptr2[2] = 76;
					ptr2[3] = 90;
					Class11.Class12.smethod_1(3U, (void*)(ptr10 + 1), 4U);
					Class11.Class12.smethod_1(uint_1, (void*)(ptr10 + 3), 4U);
					for (uint num3 = 0U; num3 < 4096U; num3 += 1U)
					{
						*(IntPtr*)(ptr6 + (ulong)num3 * (ulong)((long)sizeof(byte*)) / (ulong)sizeof(byte*)) = ptr3;
					}
					(ptr2 + num)[4] = *ptr3;
					while (ptr5 < ptr11 - 2050)
					{
						if ((num2 & 1U) == 1U)
						{
							if (ptr7 + 2050 + 128 != ptr2 + uint_1 + 2050 + 256)
							{
								Class11.Class12.smethod_5((void*)(ptr2 + num), (void*)ptr3, uint_1);
								Class11.Class12.smethod_1(0U, (void*)(ptr10 + 4), 4U);
								Class11.Class12.smethod_1(uint_1 + num + 4U, (void*)(ptr10 + 2), 4U);
								Class11.Class12.smethod_6((void*)(ptr2 + Class11.Class12.smethod_0((void*)(ptr10 + 2), 4U) - 4), "QCLZ");
								return Class11.Class12.smethod_0((void*)(ptr10 + 2), 4U);
							}
							Class11.Class12.smethod_1((uint)((ulong)(num2 >> 1) | 18446744071562067968UL), (void*)pVoid_, 4U);
							pVoid_ = ptr7;
							ptr7 += 4;
							num2 = 2147483648U;
							if ((long)(ptr7 - ptr8) > (long)(ptr5 - ptr9) && ptr5 + 4100 < ptr11)
							{
								while (ptr5 < ptr9 + 2050 - 32)
								{
									Class11.Class12.smethod_1(2147483648U, (void*)(ptr7 - 4), 4U);
									Class11.Class12.smethod_7(ptr7, ptr5, 31U);
									ptr7 += 35;
									ptr5 += 31;
								}
								ptr9 = ptr5;
								ptr8 = ptr7;
								pVoid_ = ptr7 - 4;
							}
						}
						if (Class11.Class12.smethod_0((void*)ptr5, 4U) == Class11.Class12.smethod_0((void*)(ptr5 + 1), 4U))
						{
							uint num4 = Class11.Class12.smethod_0((void*)ptr5, 4U);
							byte* ptr12 = ptr5;
							ptr5 += 5;
							while (num4 == Class11.Class12.smethod_0((void*)ptr5, 4U) && ptr5 < ptr12 + 2050 - 4)
							{
								ptr5 += 4;
							}
							Class11.Class12.smethod_1((num4 & 255U) << 16 | (uint)((uint)((long)(ptr5 - ptr12)) << 4) | 15U, (void*)ptr7, 4U);
							ptr7 += 3;
							num2 = (num2 >> 1 | 2147483648U);
						}
						else
						{
							uint num4 = Class11.Class12.smethod_0((void*)ptr5, 4U);
							uint num3 = (num4 >> 12 ^ num4) & 4095U;
							byte* ptr13 = *(IntPtr*)(ptr6 + (ulong)num3 * (ulong)((long)sizeof(byte*)) / (ulong)sizeof(byte*));
							*(IntPtr*)(ptr6 + (ulong)num3 * (ulong)((long)sizeof(byte*)) / (ulong)sizeof(byte*)) = ptr5;
							bool flag;
							if (BitConverter.IsLittleEndian)
							{
								flag = ((long)(ptr5 - ptr13) <= 131071L && (long)(ptr5 - ptr13) > 3L && ((*(uint*)ptr13 ^ *(uint*)ptr5) & 16777215U) == 0U);
							}
							else
							{
								flag = ((long)(ptr5 - ptr13) <= 131071L && (long)(ptr5 - ptr13) > 3L && *ptr5 == *ptr13 && ptr5[1] == ptr13[1] && ptr5[2] == ptr13[2]);
							}
							if (flag)
							{
								uint num5 = (uint)((long)(ptr5 - ptr13));
								if (BitConverter.IsLittleEndian)
								{
									flag = (*(uint*)ptr13 != *(uint*)ptr5);
								}
								else
								{
									flag = (ptr13[3] != ptr5[3]);
								}
								if (flag)
								{
									if (num5 <= 63U)
									{
										*ptr7 = (byte)(num5 << 2);
										ptr7++;
										num2 = (num2 >> 1 | 2147483648U);
										ptr5 += 3;
									}
									else if (num5 <= 16383U)
									{
										Class11.Class12.smethod_1(num5 << 2 | 1U, (void*)ptr7, 2U);
										ptr7 += 2;
										num2 = (num2 >> 1 | 2147483648U);
										ptr5 += 3;
									}
									else
									{
										*ptr7 = *ptr5;
										ptr7++;
										ptr5++;
										num2 >>= 1;
									}
								}
								else
								{
									num2 = (num2 >> 1 | 2147483648U);
									uint num6 = 3U;
									while (ptr13[num6] == ptr5[num6] && num6 < 2050U)
									{
										num6 += 1U;
									}
									ptr5 += num6;
									if (num6 <= 18U && num5 <= 1023U)
									{
										Class11.Class12.smethod_1(num6 - 3U << 2 | num5 << 6 | 2U, (void*)ptr7, 2U);
										ptr7 += 2;
									}
									else if (num6 <= 34U && num5 <= 65535U)
									{
										Class11.Class12.smethod_1(num6 - 3U << 3 | num5 << 8 | 3U, (void*)ptr7, 3U);
										ptr7 += 3;
									}
									else if (num6 >= 3U)
									{
										Class11.Class12.smethod_1(num6 - 3U << 4 | num5 << 15 | 7U, (void*)ptr7, 4U);
										ptr7 += 4;
									}
								}
							}
							else
							{
								*ptr7 = *ptr5;
								ptr7++;
								ptr5++;
								num2 >>= 1;
							}
						}
					}
					while (ptr5 == ptr4)
					{
						if ((num2 & 1U) == 1U)
						{
							Class11.Class12.smethod_1(num2 >> 1 | 2147483648U, (void*)pVoid_, 4U);
							pVoid_ = ptr7;
							ptr7 += 4;
							num2 = 2147483648U;
						}
						*ptr7 = *ptr5;
						ptr7++;
						ptr5++;
						num2 >>= 1;
					}
					while ((num2 & 1U) != 1U)
					{
						num2 >>= 1;
					}
					Class11.Class12.smethod_1(num2 >> 1 | 2147483648U, (void*)pVoid_, 4U);
					ptr7 += 4;
					Class11.Class12.smethod_1(1U, (void*)(ptr10 + 4), 4U);
					Class11.Class12.smethod_1((uint)((long)(ptr7 - ptr2) - 1L + 4L), (void*)(ptr10 + 2), 4U);
					Class11.Class12.smethod_6((void*)(ptr2 + Class11.Class12.smethod_0((void*)(ptr10 + 2), 4U) - 4), "QCLZ");
					array = null;
				}
				return Class11.Class12.smethod_9(byte_1);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000229C0 File Offset: 0x0001C1C0
		private unsafe static uint smethod_12(byte[] byte_0, uint uint_0, byte[] byte_1)
		{
			byte* ptr;
			if (byte_0 != null && byte_0.Length != 0)
			{
				ptr = &byte_0[0];
			}
			else
			{
				ptr = null;
			}
			byte* ptr2;
			if (byte_1 != null && byte_1.Length != 0)
			{
				ptr2 = &byte_1[0];
			}
			else
			{
				ptr2 = null;
			}
			byte* ptr3 = ptr + uint_0;
			uint num = 32U;
			byte* ptr4 = ptr3 + 32;
			byte* ptr5 = ptr2;
			uint* ptr6 = (uint*)ptr3;
			byte* ptr7 = ptr2 + Class11.Class12.smethod_0((void*)(ptr6 + 3), 4U);
			uint num2 = 1U;
			uint[] array = new uint[]
			{
				4U,
				0U,
				1U,
				0U,
				2U,
				0U,
				1U,
				0U,
				3U,
				0U,
				1U,
				0U,
				2U,
				0U,
				1U,
				0U
			};
			byte* ptr8 = ptr7 - 4;
			if (!Class11.Class12.smethod_3((void*)ptr6, "QCLZ"))
			{
				return 0U;
			}
			if (Class11.Class12.smethod_0((void*)(ptr6 + 1), 4U) != 3U)
			{
				return 0U;
			}
			if (!Class11.Class12.smethod_3((void*)(ptr3 + Class11.Class12.smethod_0((void*)(ptr6 + 2), 4U) - 4), "QCLZ"))
			{
				return 0U;
			}
			if (Class11.Class12.smethod_0((void*)(ptr6 + 4), 4U) != 1U)
			{
				Class11.Class12.smethod_5((void*)ptr2, (void*)(ptr3 + num), Class11.Class12.smethod_0((void*)(ptr6 + 3), 4U));
				return Class11.Class12.smethod_0((void*)(ptr6 + 3), 4U);
			}
			if (ptr5 >= ptr8)
			{
				ptr4 += 4;
				while (ptr5 < ptr7)
				{
					*ptr5 = *ptr4;
					ptr5++;
					ptr4++;
				}
				return (uint)((long)(ptr5 - ptr2));
			}
			for (;;)
			{
				if (num2 == 1U)
				{
					num2 = Class11.Class12.smethod_0((void*)ptr4, 4U);
					ptr4 += 4;
				}
				uint num3 = Class11.Class12.smethod_0((void*)ptr4, 4U);
				if ((num2 & 1U) == 1U)
				{
					num2 >>= 1;
					if ((num3 & 3U) == 0U)
					{
						uint num4 = (num3 & 255U) >> 2;
						Class11.Class12.smethod_7(ptr5, ptr5 - num4, 3U);
						ptr5 += 3;
						ptr4++;
					}
					else if ((num3 & 2U) == 0U)
					{
						uint num4 = (num3 & 65535U) >> 2;
						Class11.Class12.smethod_7(ptr5, ptr5 - num4, 3U);
						ptr5 += 3;
						ptr4 += 2;
					}
					else if ((num3 & 1U) == 0U)
					{
						uint num4 = (num3 & 65535U) >> 6;
						uint num5 = (num3 >> 2 & 15U) + 3U;
						Class11.Class12.smethod_7(ptr5, ptr5 - num4, num5);
						ptr5 += num5;
						ptr4 += 2;
					}
					else if ((num3 & 4U) == 0U)
					{
						uint num4 = (num3 & 16777215U) >> 8;
						uint num5 = (num3 >> 3 & 31U) + 3U;
						Class11.Class12.smethod_7(ptr5, ptr5 - num4, num5);
						ptr5 += num5;
						ptr4 += 3;
					}
					else if ((num3 & 8U) == 0U)
					{
						uint num4 = num3 >> 15;
						uint num5 = (num3 >> 4 & 2047U) + 3U;
						Class11.Class12.smethod_7(ptr5, ptr5 - num4, num5);
						ptr5 += num5;
						ptr4 += 4;
					}
					else
					{
						byte byte_2 = (byte)(num3 >> 16);
						uint num5 = num3 >> 4 & 4095U;
						Class11.Class12.smethod_4((void*)ptr5, byte_2, num5);
						ptr5 += num5;
						ptr4 += 3;
					}
				}
				else
				{
					Class11.Class12.smethod_7(ptr5, ptr4, 4U);
					ptr5 += array[(int)(num2 & 15U)];
					ptr4 += array[(int)(num2 & 15U)];
					num2 >>= (int)((byte)array[(int)(num2 & 15U)]);
					if (ptr5 >= ptr8)
					{
						break;
					}
				}
			}
			while (ptr5 < ptr7)
			{
				if (num2 == 1U)
				{
					ptr4 += 4;
					num2 = 2147483648U;
				}
				*ptr5 = *ptr4;
				ptr5++;
				ptr4++;
				num2 >>= 1;
			}
			return (uint)((long)(ptr5 - ptr2));
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00022CF4 File Offset: 0x0001C4F4
		private static byte[] smethod_13(string string_0)
		{
			byte[] array = null;
			FileStream fileStream = File.Open(string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
			try
			{
				array = new byte[fileStream.Length];
				fileStream.Read(array, 0, array.Length);
			}
			finally
			{
				fileStream.Close();
			}
			return array;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0001E505 File Offset: 0x00017D05
		public static byte[] smethod_14(string string_0)
		{
			return Class11.Class12.smethod_16(Class11.Class12.smethod_13(string_0));
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0001E512 File Offset: 0x00017D12
		public static byte[] smethod_15(string string_0)
		{
			return Class11.Class12.smethod_17(Class11.Class12.smethod_13(string_0));
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0001E51F File Offset: 0x00017D1F
		public static byte[] smethod_16(byte[] byte_0)
		{
			return Class11.Class12.smethod_19(byte_0, 0U, Convert.ToUInt32(byte_0.Length));
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0001E530 File Offset: 0x00017D30
		public static byte[] smethod_17(byte[] byte_0)
		{
			return Class11.Class12.smethod_20(byte_0, 0U);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0001E539 File Offset: 0x00017D39
		internal static object smethod_18(byte[] byte_0)
		{
			return typeof(Assembly).GetMethod("Load", new Type[]
			{
				typeof(byte[])
			}).Invoke(null, new object[]
			{
				byte_0
			});
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00022D40 File Offset: 0x0001C540
		public static byte[] smethod_19(byte[] byte_0, uint uint_0, uint uint_1)
		{
			byte[] array = new byte[uint_1 + 36000U];
			uint num = Class11.Class12.smethod_11(byte_0, uint_0, array, uint_1);
			byte[] array2 = new byte[num];
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				array2[(int)num2] = array[(int)num2];
			}
			return array2;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00022D80 File Offset: 0x0001C580
		public static byte[] smethod_20(byte[] byte_0, uint uint_0)
		{
			uint num = Class11.Class12.smethod_10(byte_0, uint_0);
			byte[] array = null;
			if (num != 0U)
			{
				array = new byte[num];
				Class11.Class12.smethod_12(byte_0, uint_0, array);
			}
			return array;
		}
	}
}
