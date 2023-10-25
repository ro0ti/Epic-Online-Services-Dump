using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200042D RID: 1069
	[Token(Token = "0x200042D")]
	internal struct LobbySearchSetParameterOptionsInternal : ISettable<LobbySearchSetParameterOptions>, IDisposable
	{
		// Token: 0x170007FD RID: 2045
		// (set) Token: 0x06001C18 RID: 7192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007FD")]
		public AttributeData? Parameter
		{
			[Token(Token = "0x6001C18")]
			[Address(RVA = "0x52C2E0", Offset = "0x52A8E0", VA = "0x18052C2E0")]
			set
			{
			}
		}

		// Token: 0x170007FE RID: 2046
		// (set) Token: 0x06001C19 RID: 7193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007FE")]
		public ComparisonOp ComparisonOp
		{
			[Token(Token = "0x6001C19")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C1A")]
		[Address(RVA = "0x52C230", Offset = "0x52A830", VA = "0x18052C230", Slot = "4")]
		public void Set(ref LobbySearchSetParameterOptions other)
		{
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C1B")]
		[Address(RVA = "0x52C100", Offset = "0x52A700", VA = "0x18052C100", Slot = "5")]
		public void Set(ref LobbySearchSetParameterOptions? other)
		{
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C1C")]
		[Address(RVA = "0x52C0B0", Offset = "0x52A6B0", VA = "0x18052C0B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000CCB RID: 3275
		[Token(Token = "0x4000CCB")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000CCC RID: 3276
		[Token(Token = "0x4000CCC")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Parameter;

		// Token: 0x04000CCD RID: 3277
		[Token(Token = "0x4000CCD")]
		[FieldOffset(Offset = "0x10")]
		private ComparisonOp m_ComparisonOp;
	}
}
