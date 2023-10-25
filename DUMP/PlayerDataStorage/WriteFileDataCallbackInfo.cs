using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x02000311 RID: 785
	[Token(Token = "0x2000311")]
	public struct WriteFileDataCallbackInfo : ICallbackInfo
	{
		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600154C RID: 5452 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005AE")]
		public object ClientData
		{
			[Token(Token = "0x600154B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600154C")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600154E RID: 5454 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005AF")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600154D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600154E")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001550 RID: 5456 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005B0")]
		public Utf8String Filename
		{
			[Token(Token = "0x600154F")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001550")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x000060D4 File Offset: 0x000042D4
		// (set) Token: 0x06001552 RID: 5458 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005B1")]
		public uint DataBufferLengthBytes
		{
			[Token(Token = "0x6001551")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6001552")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x000060EC File Offset: 0x000042EC
		[Token(Token = "0x6001553")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001554")]
		[Address(RVA = "0x5049D0", Offset = "0x502FD0", VA = "0x1805049D0")]
		internal void Set(ref WriteFileDataCallbackInfoInternal other)
		{
		}
	}
}
