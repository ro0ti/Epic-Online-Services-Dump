using System;


namespace Epic.OnlineServices
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public sealed class EpicAccountId : Handle
	{
		// Token: 0x0600034D RID: 845 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x3E4E80", Offset = "0x3E3480", VA = "0x1803E4E80")]
		public EpicAccountId()
		{
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x49FCF0", Offset = "0x49E2F0", VA = "0x18049FCF0")]
		public EpicAccountId(IntPtr innerHandle)
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x4A4260", Offset = "0x4A2860", VA = "0x1804A4260")]
		public static EpicAccountId FromString(Utf8String accountIdString)
		{
			return null;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x4A4260", Offset = "0x4A2860", VA = "0x1804A4260")]
		public static explicit operator EpicAccountId(Utf8String value)
		{
			return null;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x4A43B0", Offset = "0x4A29B0", VA = "0x1804A43B0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x4A44A0", Offset = "0x4A2AA0", VA = "0x1804A44A0")]
		public Result ToString(out Utf8String outBuffer)
		{
			return Result.Success;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x4A45F0", Offset = "0x4A2BF0", VA = "0x1804A45F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x49FAE0", Offset = "0x49E0E0", VA = "0x18049FAE0", Slot = "6")]
		public override string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x4A4670", Offset = "0x4A2C70", VA = "0x1804A4670")]
		public static explicit operator Utf8String(EpicAccountId value)
		{
			return null;
		}

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		public const int EpicaccountidMaxLength = 32;
	}
}
