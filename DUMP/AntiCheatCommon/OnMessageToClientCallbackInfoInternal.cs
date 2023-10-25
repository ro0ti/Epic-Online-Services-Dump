using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006DF RID: 1759
	[Token(Token = "0x20006DF")]
	internal struct OnMessageToClientCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnMessageToClientCallbackInfo>, ISettable<OnMessageToClientCallbackInfo>, IDisposable
	{
		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06002D27 RID: 11559 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002D28 RID: 11560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D6C")]
		public object ClientData
		{
			[Token(Token = "0x6002D27")]
			[Address(RVA = "0x5786A0", Offset = "0x576CA0", VA = "0x1805786A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D28")]
			[Address(RVA = "0x578790", Offset = "0x576D90", VA = "0x180578790")]
			set
			{
			}
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06002D29 RID: 11561 RVA: 0x0000B9E4 File Offset: 0x00009BE4
		[Token(Token = "0x17000D6D")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002D29")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06002D2A RID: 11562 RVA: 0x0000B9FC File Offset: 0x00009BFC
		// (set) Token: 0x06002D2B RID: 11563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D6E")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002D2A")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002D2B")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06002D2C RID: 11564 RVA: 0x0000BA14 File Offset: 0x00009C14
		// (set) Token: 0x06002D2D RID: 11565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D6F")]
		public ArraySegment<byte> MessageData
		{
			[Token(Token = "0x6002D2C")]
			[Address(RVA = "0x578710", Offset = "0x576D10", VA = "0x180578710")]
			get
			{
				return default(ArraySegment<byte>);
			}
			[Token(Token = "0x6002D2D")]
			[Address(RVA = "0x5787F0", Offset = "0x576DF0", VA = "0x1805787F0")]
			set
			{
			}
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D2E")]
		[Address(RVA = "0x5785D0", Offset = "0x576BD0", VA = "0x1805785D0", Slot = "6")]
		public void Set(ref OnMessageToClientCallbackInfo other)
		{
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D2F")]
		[Address(RVA = "0x5784A0", Offset = "0x576AA0", VA = "0x1805784A0", Slot = "7")]
		public void Set(ref OnMessageToClientCallbackInfo? other)
		{
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D30")]
		[Address(RVA = "0x578420", Offset = "0x576A20", VA = "0x180578420", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D31")]
		[Address(RVA = "0x578480", Offset = "0x576A80", VA = "0x180578480", Slot = "5")]
		public void Get(out OnMessageToClientCallbackInfo output)
		{
		}

		// Token: 0x0400140C RID: 5132
		[Token(Token = "0x400140C")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x0400140D RID: 5133
		[Token(Token = "0x400140D")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientHandle;

		// Token: 0x0400140E RID: 5134
		[Token(Token = "0x400140E")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_MessageData;

		// Token: 0x0400140F RID: 5135
		[Token(Token = "0x400140F")]
		[FieldOffset(Offset = "0x18")]
		private uint m_MessageDataSizeBytes;
	}
}
