using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200058B RID: 1419
	[Token(Token = "0x200058B")]
	public struct QueryOwnershipTokenCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x0600248A RID: 9354 RVA: 0x0000989C File Offset: 0x00007A9C
		// (set) Token: 0x0600248B RID: 9355 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A9E")]
		public Result ResultCode
		{
			[Token(Token = "0x600248A")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x600248B")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600248D RID: 9357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A9F")]
		public object ClientData
		{
			[Token(Token = "0x600248C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600248D")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x0600248E RID: 9358 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600248F RID: 9359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AA0")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600248E")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600248F")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06002490 RID: 9360 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002491 RID: 9361 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AA1")]
		public Utf8String OwnershipToken
		{
			[Token(Token = "0x6002490")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002491")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x000098B4 File Offset: 0x00007AB4
		[Token(Token = "0x6002492")]
		[Address(RVA = "0x54E970", Offset = "0x54CF70", VA = "0x18054E970", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002493")]
		[Address(RVA = "0x54E9C0", Offset = "0x54CFC0", VA = "0x18054E9C0")]
		internal void Set(ref QueryOwnershipTokenCallbackInfoInternal other)
		{
		}
	}
}
