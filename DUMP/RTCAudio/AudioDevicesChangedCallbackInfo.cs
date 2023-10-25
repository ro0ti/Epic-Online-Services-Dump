using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001C2 RID: 450
	[Token(Token = "0x20001C2")]
	public struct AudioDevicesChangedCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CD5 RID: 3285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700030C")]
		public object ClientData
		{
			[Token(Token = "0x6000CD4")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000CD5")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x000046C4 File Offset: 0x000028C4
		[Token(Token = "0x6000CD6")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CD7")]
		[Address(RVA = "0x4D5E20", Offset = "0x4D4420", VA = "0x1804D5E20")]
		internal void Set(ref AudioDevicesChangedCallbackInfoInternal other)
		{
		}
	}
}
