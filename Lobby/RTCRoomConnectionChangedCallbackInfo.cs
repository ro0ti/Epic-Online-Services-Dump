using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200046E RID: 1134
	[Token(Token = "0x200046E")]
	public struct RTCRoomConnectionChangedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D52 RID: 7506 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000831")]
		public object ClientData
		{
			[Token(Token = "0x6001D51")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001D52")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D54 RID: 7508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000832")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001D53")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001D54")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D56 RID: 7510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000833")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001D55")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001D56")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x0000809C File Offset: 0x0000629C
		// (set) Token: 0x06001D58 RID: 7512 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000834")]
		public bool IsConnected
		{
			[Token(Token = "0x6001D57")]
			[Address(RVA = "0x4BED50", Offset = "0x4BD350", VA = "0x1804BED50")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D58")]
			[Address(RVA = "0x4BED60", Offset = "0x4BD360", VA = "0x1804BED60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x000080B4 File Offset: 0x000062B4
		// (set) Token: 0x06001D5A RID: 7514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000835")]
		public Result DisconnectReason
		{
			[Token(Token = "0x6001D59")]
			[Address(RVA = "0x4A5AF0", Offset = "0x4A40F0", VA = "0x1804A5AF0")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001D5A")]
			[Address(RVA = "0x4A5CB0", Offset = "0x4A42B0", VA = "0x1804A5CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x000080CC File Offset: 0x000062CC
		[Token(Token = "0x6001D5B")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D5C")]
		[Address(RVA = "0x535060", Offset = "0x533660", VA = "0x180535060")]
		internal void Set(ref RTCRoomConnectionChangedCallbackInfoInternal other)
		{
		}
	}
}
