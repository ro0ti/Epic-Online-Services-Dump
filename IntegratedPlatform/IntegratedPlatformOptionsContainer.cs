using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004E2 RID: 1250
	[Token(Token = "0x20004E2")]
	public sealed class IntegratedPlatformOptionsContainer : Handle
	{
		// Token: 0x06002013 RID: 8211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002013")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public IntegratedPlatformOptionsContainer()
		{
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002014")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public IntegratedPlatformOptionsContainer(IntPtr innerHandle)
		{
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x00008A5C File Offset: 0x00006C5C
		[Token(Token = "0x6002015")]
		[Address(RVA = "0x524BB0", Offset = "0x5231B0", VA = "0x180524BB0")]
		public Result Add(ref IntegratedPlatformOptionsContainerAddOptions inOptions)
		{
			return Result.Success;
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002016")]
		[Address(RVA = "0x524CB0", Offset = "0x5232B0", VA = "0x180524CB0")]
		public void Release()
		{
		}

		// Token: 0x04000E34 RID: 3636
		[Token(Token = "0x4000E34")]
		public const int IntegratedplatformoptionscontainerAddApiLatest = 1;
	}
}
