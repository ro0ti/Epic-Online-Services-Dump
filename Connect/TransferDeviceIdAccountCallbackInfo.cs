using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x0200063B RID: 1595
	[Token(Token = "0x200063B")]
	public struct TransferDeviceIdAccountCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x060028C2 RID: 10434 RVA: 0x0000A40C File Offset: 0x0000860C
		// (set) Token: 0x060028C3 RID: 10435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BD1")]
		public Result ResultCode
		{
			[Token(Token = "0x60028C2")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60028C3")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x060028C4 RID: 10436 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028C5 RID: 10437 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BD2")]
		public object ClientData
		{
			[Token(Token = "0x60028C4")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60028C5")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x060028C6 RID: 10438 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028C7 RID: 10439 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BD3")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60028C6")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60028C7")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x0000A424 File Offset: 0x00008624
		[Token(Token = "0x60028C8")]
		[Address(RVA = "0x568AB0", Offset = "0x5670B0", VA = "0x180568AB0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028C9")]
		[Address(RVA = "0x568B00", Offset = "0x567100", VA = "0x180568B00")]
		internal void Set(ref TransferDeviceIdAccountCallbackInfoInternal other)
		{
		}
	}
}
