using System;
// Dumped by ro0ti

namespace Epic.OnlineServices
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	public sealed class ContinuanceToken : Handle
	{
		// Token: 0x06000347 RID: 839 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x3E4E80", Offset = "0x3E3480", VA = "0x1803E4E80")]
		public ContinuanceToken()
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x49FCF0", Offset = "0x49E2F0", VA = "0x18049FCF0")]
		public ContinuanceToken(IntPtr innerHandle)
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x49FB20", Offset = "0x49E120", VA = "0x18049FB20")]
		public Result ToString(out Utf8String outBuffer)
		{
			return Result.Success;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x49FC70", Offset = "0x49E270", VA = "0x18049FC70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x49FAE0", Offset = "0x49E0E0", VA = "0x18049FAE0", Slot = "6")]
		public override string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x49FD20", Offset = "0x49E320", VA = "0x18049FD20")]
		public static explicit operator Utf8String(ContinuanceToken value)
		{
			return null;
		}
	}
}
