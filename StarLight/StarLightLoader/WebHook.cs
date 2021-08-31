using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;

namespace Starlight
{
	// Token: 0x0200000E RID: 14
	public class WebHook
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0001E1CF File Offset: 0x000179CF
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0001E1D7 File Offset: 0x000179D7
		[JsonProperty("content")]
		public string _Content { get; private set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0001E1E0 File Offset: 0x000179E0
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0001E1E8 File Offset: 0x000179E8
		public string _URL { get; private set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0001E1F1 File Offset: 0x000179F1
		// (set) Token: 0x06000045 RID: 69 RVA: 0x0001E1F9 File Offset: 0x000179F9
		public HttpClient _Client { get; private set; }

		// Token: 0x06000046 RID: 70 RVA: 0x0001E202 File Offset: 0x00017A02
		public WebHook(string Pr2wxpQ0dEdTX93KS3)
		{
			Class10.mLqA1qsz6sJ2l();
			base..ctor();
			this._URL = Pr2wxpQ0dEdTX93KS3;
			this._Client = new HttpClient();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0001F54C File Offset: 0x00018D4C
		public void Send(string B0Zgd5j4B9qZ5I9YKi)
		{
			this._Content = B0Zgd5j4B9qZ5I9YKi;
			StringContent content = new StringContent(JsonConvert.SerializeObject(this), Encoding.UTF8, "application/json");
			this._Client.PostAsync(this._URL, content);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0001E048 File Offset: 0x00017848
		// Note: this type is marked as 'beforefieldinit'.
		static WebHook()
		{
			Class11.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x04000029 RID: 41
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400002A RID: 42
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_1;

		// Token: 0x0400002B RID: 43
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private HttpClient httpClient_0;
	}
}
