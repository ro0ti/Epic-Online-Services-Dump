using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200052C RID: 1324
	[Token(Token = "0x200052C")]
	public struct CheckoutCallbackInfo : ICallbackInfo
	{
		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x0000923C File Offset: 0x0000743C
		// (set) Token: 0x06002251 RID: 8785 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009DA")]
		public Result ResultCode
		{
			[Token(Token = "0x6002250")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002251")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002253 RID: 8787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009DB")]
		public object ClientData
		{
			[Token(Token = "0x6002252")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002253")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009DC")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002254")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002255")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002257 RID: 8791 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009DD")]
		public Utf8String TransactionId
		{
			[Token(Token = "0x6002256")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002257")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x00009254 File Offset: 0x00007454
		[Token(Token = "0x6002258")]
		[Address(RVA = "0x53CF20", Offset = "0x53B520", VA = "0x18053CF20", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002259")]
		[Address(RVA = "0x53CF70", Offset = "0x53B570", VA = "0x18053CF70")]
		internal void Set(ref CheckoutCallbackInfoInternal other)
		{
		}
	}
}
