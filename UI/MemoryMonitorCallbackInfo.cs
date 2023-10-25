using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.UI
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public struct MemoryMonitorCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700009D")]
		public object ClientData
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0000293C File Offset: 0x00000B3C
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700009E")]
		public IntPtr SystemMemoryMonitorReport
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00002954 File Offset: 0x00000B54
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x4AAA30", Offset = "0x4A9030", VA = "0x1804AAA30")]
		internal void Set(ref MemoryMonitorCallbackInfoInternal other)
		{
		}
	}
}
