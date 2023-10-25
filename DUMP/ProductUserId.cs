using System;


namespace Epic.OnlineServices
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public sealed class ProductUserId : Handle
	{
		// Token: 0x06000375 RID: 885 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x3E4E80", Offset = "0x3E3480", VA = "0x1803E4E80")]
		public ProductUserId()
		{
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x49FCF0", Offset = "0x49E2F0", VA = "0x18049FCF0")]
		public ProductUserId(IntPtr innerHandle)
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x4ACEB0", Offset = "0x4AB4B0", VA = "0x1804ACEB0")]
		public static ProductUserId FromString(Utf8String productUserIdString)
		{
			return null;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x4ACEB0", Offset = "0x4AB4B0", VA = "0x1804ACEB0")]
		public static explicit operator ProductUserId(Utf8String value)
		{
			return null;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x4AD000", Offset = "0x4AB600", VA = "0x1804AD000")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x4AD0F0", Offset = "0x4AB6F0", VA = "0x1804AD0F0")]
		public Result ToString(out Utf8String outBuffer)
		{
			return Result.Success;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x4AD240", Offset = "0x4AB840", VA = "0x1804AD240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x49FAE0", Offset = "0x49E0E0", VA = "0x18049FAE0", Slot = "6")]
		public override string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x4AD2C0", Offset = "0x4AB8C0", VA = "0x1804AD2C0")]
		public static explicit operator Utf8String(ProductUserId value)
		{
			return null;
		}

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		public const int ProductuseridMaxLength = 32;
	}
}
