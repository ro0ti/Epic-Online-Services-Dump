using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000195 RID: 405
	[Token(Token = "0x2000195")]
	public struct StartSessionCallbackInfo : ICallbackInfo
	{
		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x00004364 File Offset: 0x00002564
		// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002A2")]
		public Result ResultCode
		{
			[Token(Token = "0x6000BB8")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002A3")]
		public object ClientData
		{
			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0000437C File Offset: 0x0000257C
		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x4E67C0", Offset = "0x4E4DC0", VA = "0x1804E67C0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x4E6810", Offset = "0x4E4E10", VA = "0x1804E6810")]
		internal void Set(ref StartSessionCallbackInfoInternal other)
		{
		}
	}
}
