using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001CA RID: 458
	[Token(Token = "0x20001CA")]
	public struct AudioOutputStateCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000D19 RID: 3353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000324")]
		public object ClientData
		{
			[Token(Token = "0x6000D18")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000D19")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000D1B RID: 3355 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000325")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000D1A")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000D1B")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000D1D RID: 3357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000326")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000D1C")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000D1D")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x000047B4 File Offset: 0x000029B4
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000327")]
		public RTCAudioOutputStatus Status
		{
			[Token(Token = "0x6000D1E")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return RTCAudioOutputStatus.Idle;
			}
			[Token(Token = "0x6000D1F")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x000047CC File Offset: 0x000029CC
		[Token(Token = "0x6000D20")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D21")]
		[Address(RVA = "0x4D77B0", Offset = "0x4D5DB0", VA = "0x1804D77B0")]
		internal void Set(ref AudioOutputStateCallbackInfoInternal other)
		{
		}
	}
}
