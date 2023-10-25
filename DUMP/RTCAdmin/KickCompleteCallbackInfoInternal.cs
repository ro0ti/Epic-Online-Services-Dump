using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x02000243 RID: 579
	[Token(Token = "0x2000243")]
	internal struct KickCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<KickCompleteCallbackInfo>, ISettable<KickCompleteCallbackInfo>, IDisposable
	{
		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x000051A4 File Offset: 0x000033A4
		// (set) Token: 0x06001001 RID: 4097 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000401")]
		public Result ResultCode
		{
			[Token(Token = "0x6001000")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001001")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001003 RID: 4099 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000402")]
		public object ClientData
		{
			[Token(Token = "0x6001002")]
			[Address(RVA = "0x4DA000", Offset = "0x4D8600", VA = "0x1804DA000")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001003")]
			[Address(RVA = "0x4DA070", Offset = "0x4D8670", VA = "0x1804DA070")]
			set
			{
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x000051BC File Offset: 0x000033BC
		[Token(Token = "0x17000403")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001004")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001005")]
		[Address(RVA = "0x4D9EE0", Offset = "0x4D84E0", VA = "0x1804D9EE0", Slot = "6")]
		public void Set(ref KickCompleteCallbackInfo other)
		{
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001006")]
		[Address(RVA = "0x4D9F40", Offset = "0x4D8540", VA = "0x1804D9F40", Slot = "7")]
		public void Set(ref KickCompleteCallbackInfo? other)
		{
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001007")]
		[Address(RVA = "0x4D9E70", Offset = "0x4D8470", VA = "0x1804D9E70", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001008")]
		[Address(RVA = "0x4D9EC0", Offset = "0x4D84C0", VA = "0x1804D9EC0", Slot = "5")]
		public void Get(out KickCompleteCallbackInfo output)
		{
		}

		// Token: 0x04000729 RID: 1833
		[Token(Token = "0x4000729")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
