using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Starlight
{
	// Token: 0x02000003 RID: 3
	public class AuthEncryptionExtension
	{
		// Token: 0x06000002 RID: 2 RVA: 0x0001E574 File Offset: 0x00017D74
		internal static long smethod_0()
		{
			return -5174102234038325131L;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0001E58C File Offset: 0x00017D8C
		public AuthEncryptionExtension(string string_0)
		{
			Class10.mLqA1qsz6sJ2l();
			this.list_0 = new List<int>();
			base..ctor();
			byte[] bytes = Encoding.ASCII.GetBytes(string_0);
			for (int i = 0; i < bytes.Length; i++)
			{
				this.dhlysQldJ().Add((int)bytes[i] + 788851 / bytes.Length);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0001E04F File Offset: 0x0001784F
		[CompilerGenerated]
		private List<int> dhlysQldJ()
		{
			return this.list_0;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0001E057 File Offset: 0x00017857
		[CompilerGenerated]
		private void method_0(List<int> list_1)
		{
			this.list_0 = list_1;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0001E5E4 File Offset: 0x00017DE4
		public string Encrypted()
		{
			return string.Join<int>("`", this.dhlysQldJ());
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0001E604 File Offset: 0x00017E04
		public string Reversed()
		{
			List<byte> list = new List<byte>();
			for (int i = 0; i < this.dhlysQldJ().Count; i++)
			{
				list.Add((byte)(this.dhlysQldJ()[i] - 788851 / this.dhlysQldJ().Count));
			}
			return Encoding.ASCII.GetString(list.ToArray());
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0001E048 File Offset: 0x00017848
		// Note: this type is marked as 'beforefieldinit'.
		static AuthEncryptionExtension()
		{
			Class11.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x04000001 RID: 1
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private List<int> list_0;
	}
}
