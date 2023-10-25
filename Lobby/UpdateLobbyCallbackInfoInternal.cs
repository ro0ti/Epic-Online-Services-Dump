using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000477 RID: 1143
	[Token(Token = "0x2000477")]
	internal struct UpdateLobbyCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateLobbyCallbackInfo>, ISettable<UpdateLobbyCallbackInfo>, IDisposable
	{
		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x0000821C File Offset: 0x0000641C
		// (set) Token: 0x06001DB3 RID: 7603 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000859")]
		public Result ResultCode
		{
			[Token(Token = "0x6001DB2")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001DB3")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700085A")]
		public object ClientData
		{
			[Token(Token = "0x6001DB4")]
			[Address(RVA = "0x537780", Offset = "0x535D80", VA = "0x180537780")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DB5")]
			[Address(RVA = "0x537860", Offset = "0x535E60", VA = "0x180537860")]
			set
			{
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x00008234 File Offset: 0x00006434
		[Token(Token = "0x1700085B")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001DB6")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700085C")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001DB7")]
			[Address(RVA = "0x5377F0", Offset = "0x535DF0", VA = "0x1805377F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DB8")]
			[Address(RVA = "0x5378C0", Offset = "0x535EC0", VA = "0x1805378C0")]
			set
			{
			}
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DB9")]
		[Address(RVA = "0x5375A0", Offset = "0x535BA0", VA = "0x1805375A0", Slot = "6")]
		public void Set(ref UpdateLobbyCallbackInfo other)
		{
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DBA")]
		[Address(RVA = "0x537660", Offset = "0x535C60", VA = "0x180537660", Slot = "7")]
		public void Set(ref UpdateLobbyCallbackInfo? other)
		{
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DBB")]
		[Address(RVA = "0x537520", Offset = "0x535B20", VA = "0x180537520", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DBC")]
		[Address(RVA = "0x537580", Offset = "0x535B80", VA = "0x180537580", Slot = "5")]
		public void Get(out UpdateLobbyCallbackInfo output)
		{
		}

		// Token: 0x04000D28 RID: 3368
		[Token(Token = "0x4000D28")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000D29 RID: 3369
		[Token(Token = "0x4000D29")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000D2A RID: 3370
		[Token(Token = "0x4000D2A")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LobbyId;
	}
}
