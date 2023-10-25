using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000427 RID: 1063
	[Token(Token = "0x2000427")]
	internal struct LobbySearchRemoveParameterOptionsInternal : ISettable<LobbySearchRemoveParameterOptions>, IDisposable
	{
		// Token: 0x170007F5 RID: 2037
		// (set) Token: 0x06001C03 RID: 7171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007F5")]
		public Utf8String Key
		{
			[Token(Token = "0x6001C03")]
			[Address(RVA = "0x52BE40", Offset = "0x52A440", VA = "0x18052BE40")]
			set
			{
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (set) Token: 0x06001C04 RID: 7172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007F6")]
		public ComparisonOp ComparisonOp
		{
			[Token(Token = "0x6001C04")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C05")]
		[Address(RVA = "0x52BCF0", Offset = "0x52A2F0", VA = "0x18052BCF0", Slot = "4")]
		public void Set(ref LobbySearchRemoveParameterOptions other)
		{
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C06")]
		[Address(RVA = "0x52BD70", Offset = "0x52A370", VA = "0x18052BD70", Slot = "5")]
		public void Set(ref LobbySearchRemoveParameterOptions? other)
		{
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C07")]
		[Address(RVA = "0x52BCA0", Offset = "0x52A2A0", VA = "0x18052BCA0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000CC0 RID: 3264
		[Token(Token = "0x4000CC0")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000CC1 RID: 3265
		[Token(Token = "0x4000CC1")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Key;

		// Token: 0x04000CC2 RID: 3266
		[Token(Token = "0x4000CC2")]
		[FieldOffset(Offset = "0x10")]
		private ComparisonOp m_ComparisonOp;
	}
}
