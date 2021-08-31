using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Starlight
{
	// Token: 0x02000004 RID: 4
	public class AuthDecryptionExtension
	{
		// Token: 0x06000009 RID: 9 RVA: 0x0001E574 File Offset: 0x00017D74
		internal static long smethod_0()
		{
			return -5174102234038325131L;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0001E668 File Offset: 0x00017E68
		public AuthDecryptionExtension(string string_0)
		{
			Class10.mLqA1qsz6sJ2l();
			this.list_0 = new List<int>();
			base..ctor();
			List<int> list = new List<int>();
			string[] array = string_0.Split(new char[]
			{
				'`'
			});
			for (int i = 0; i < array.Length; i++)
			{
				list.Add(int.Parse(array[i]));
			}
			this.method_1(list);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0001E060 File Offset: 0x00017860
		[CompilerGenerated]
		private List<int> method_0()
		{
			return this.list_0;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0001E068 File Offset: 0x00017868
		[CompilerGenerated]
		private void method_1(List<int> list_1)
		{
			this.list_0 = list_1;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0001E6C8 File Offset: 0x00017EC8
		public string Reversed()
		{
			List<byte> list = new List<byte>();
			for (int i = 0; i < this.method_0().Count; i++)
			{
				list.Add((byte)(this.method_0()[i] - 788851 / this.method_0().Count));
			}
			return Encoding.ASCII.GetString(list.ToArray());
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0001E048 File Offset: 0x00017848
		// Note: this type is marked as 'beforefieldinit'.
		static AuthDecryptionExtension()
		{
			Class11.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x04000002 RID: 2
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private List<int> list_0;
	}
}
