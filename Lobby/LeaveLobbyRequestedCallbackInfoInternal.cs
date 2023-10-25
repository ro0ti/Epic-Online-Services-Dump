using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003DE RID: 990
	[Token(Token = "0x20003DE")]
	internal struct LeaveLobbyRequestedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LeaveLobbyRequestedCallbackInfo>, ISettable<LeaveLobbyRequestedCallbackInfo>, IDisposable
	{
		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001A2B RID: 6699 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A2C RID: 6700 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700076F")]
		public object ClientData
		{
			[Token(Token = "0x6001A2B")]
			[Address(RVA = "0x510E40", Offset = "0x50F440", VA = "0x180510E40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A2C")]
			[Address(RVA = "0x510FA0", Offset = "0x50F5A0", VA = "0x180510FA0")]
			set
			{
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001A2D RID: 6701 RVA: 0x0000752C File Offset: 0x0000572C
		[Token(Token = "0x17000770")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001A2D")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A2F RID: 6703 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000771")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001A2E")]
			[Address(RVA = "0x510F20", Offset = "0x50F520", VA = "0x180510F20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A2F")]
			[Address(RVA = "0x511060", Offset = "0x50F660", VA = "0x180511060")]
			set
			{
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A31 RID: 6705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000772")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001A30")]
			[Address(RVA = "0x510EB0", Offset = "0x50F4B0", VA = "0x180510EB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A31")]
			[Address(RVA = "0x511000", Offset = "0x50F600", VA = "0x180511000")]
			set
			{
			}
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A32")]
		[Address(RVA = "0x510D40", Offset = "0x50F340", VA = "0x180510D40", Slot = "6")]
		public void Set(ref LeaveLobbyRequestedCallbackInfo other)
		{
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A33")]
		[Address(RVA = "0x510BE0", Offset = "0x50F1E0", VA = "0x180510BE0", Slot = "7")]
		public void Set(ref LeaveLobbyRequestedCallbackInfo? other)
		{
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A34")]
		[Address(RVA = "0x510B60", Offset = "0x50F160", VA = "0x180510B60", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A35")]
		[Address(RVA = "0x510BC0", Offset = "0x50F1C0", VA = "0x180510BC0", Slot = "5")]
		public void Get(out LeaveLobbyRequestedCallbackInfo output)
		{
		}

		// Token: 0x04000BC9 RID: 3017
		[Token(Token = "0x4000BC9")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000BCA RID: 3018
		[Token(Token = "0x4000BCA")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000BCB RID: 3019
		[Token(Token = "0x4000BCB")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LobbyId;
	}
}
