using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002BC RID: 700
	[Token(Token = "0x20002BC")]
	public sealed class PresenceModification : Handle
	{
		// Token: 0x06001334 RID: 4916 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001334")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public PresenceModification()
		{
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001335")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public PresenceModification(IntPtr innerHandle)
		{
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x000059CC File Offset: 0x00003BCC
		[Token(Token = "0x6001336")]
		[Address(RVA = "0x4FC730", Offset = "0x4FAD30", VA = "0x1804FC730")]
		public Result DeleteData(ref PresenceModificationDeleteDataOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001337")]
		[Address(RVA = "0x4FC820", Offset = "0x4FAE20", VA = "0x1804FC820")]
		public void Release()
		{
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x000059E4 File Offset: 0x00003BE4
		[Token(Token = "0x6001338")]
		[Address(RVA = "0x4FC830", Offset = "0x4FAE30", VA = "0x1804FC830")]
		public Result SetData(ref PresenceModificationSetDataOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x000059FC File Offset: 0x00003BFC
		[Token(Token = "0x6001339")]
		[Address(RVA = "0x4FC920", Offset = "0x4FAF20", VA = "0x1804FC920")]
		public Result SetJoinInfo(ref PresenceModificationSetJoinInfoOptions options)
		{
			return Result.Success;
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00005A14 File Offset: 0x00003C14
		[Token(Token = "0x600133A")]
		[Address(RVA = "0x4FCA00", Offset = "0x4FB000", VA = "0x1804FCA00")]
		public Result SetRawRichText(ref PresenceModificationSetRawRichTextOptions options)
		{
			return Result.Success;
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x00005A2C File Offset: 0x00003C2C
		[Token(Token = "0x600133B")]
		[Address(RVA = "0x4FCAE0", Offset = "0x4FB0E0", VA = "0x1804FCAE0")]
		public Result SetStatus(ref PresenceModificationSetStatusOptions options)
		{
			return Result.Success;
		}

		// Token: 0x04000885 RID: 2181
		[Token(Token = "0x4000885")]
		public const int PresencemodificationDatarecordidApiLatest = 1;

		// Token: 0x04000886 RID: 2182
		[Token(Token = "0x4000886")]
		public const int PresencemodificationDeletedataApiLatest = 1;

		// Token: 0x04000887 RID: 2183
		[Token(Token = "0x4000887")]
		public const int PresencemodificationJoininfoMaxLength = 255;

		// Token: 0x04000888 RID: 2184
		[Token(Token = "0x4000888")]
		public const int PresencemodificationSetdataApiLatest = 1;

		// Token: 0x04000889 RID: 2185
		[Token(Token = "0x4000889")]
		public const int PresencemodificationSetjoininfoApiLatest = 1;

		// Token: 0x0400088A RID: 2186
		[Token(Token = "0x400088A")]
		public const int PresencemodificationSetrawrichtextApiLatest = 1;

		// Token: 0x0400088B RID: 2187
		[Token(Token = "0x400088B")]
		public const int PresencemodificationSetstatusApiLatest = 1;
	}
}
