using System;


namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002C6 RID: 710
	[Token(Token = "0x20002C6")]
	internal struct PresenceModificationSetRawRichTextOptionsInternal : ISettable<PresenceModificationSetRawRichTextOptions>, IDisposable
	{
		// Token: 0x17000514 RID: 1300
		// (set) Token: 0x06001359 RID: 4953 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000514")]
		public Utf8String RichText
		{
			[Token(Token = "0x6001359")]
			[Address(RVA = "0x4FC670", Offset = "0x4FAC70", VA = "0x1804FC670")]
			set
			{
			}
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600135A")]
		[Address(RVA = "0x4FC610", Offset = "0x4FAC10", VA = "0x1804FC610", Slot = "4")]
		public void Set(ref PresenceModificationSetRawRichTextOptions other)
		{
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600135B")]
		[Address(RVA = "0x4FC570", Offset = "0x4FAB70", VA = "0x1804FC570", Slot = "5")]
		public void Set(ref PresenceModificationSetRawRichTextOptions? other)
		{
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600135C")]
		[Address(RVA = "0x4FC520", Offset = "0x4FAB20", VA = "0x1804FC520", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400089B RID: 2203
		[Token(Token = "0x400089B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400089C RID: 2204
		[Token(Token = "0x400089C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_RichText;
	}
}
