using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000157 RID: 343
	[Token(Token = "0x2000157")]
	public sealed class SessionDetails : Handle
	{
		// Token: 0x06000A38 RID: 2616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public SessionDetails()
		{
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public SessionDetails(IntPtr innerHandle)
		{
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00003C2C File Offset: 0x00001E2C
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x4C8AE0", Offset = "0x4C70E0", VA = "0x1804C8AE0")]
		public Result CopyInfo(ref SessionDetailsCopyInfoOptions options, out SessionDetailsInfo? outSessionInfo)
		{
			return Result.Success;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00003C44 File Offset: 0x00001E44
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x4C8BC0", Offset = "0x4C71C0", VA = "0x1804C8BC0")]
		public Result CopySessionAttributeByIndex(ref SessionDetailsCopySessionAttributeByIndexOptions options, out SessionDetailsAttribute? outSessionAttribute)
		{
			return Result.Success;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00003C5C File Offset: 0x00001E5C
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x4C8CB0", Offset = "0x4C72B0", VA = "0x1804C8CB0")]
		public Result CopySessionAttributeByKey(ref SessionDetailsCopySessionAttributeByKeyOptions options, out SessionDetailsAttribute? outSessionAttribute)
		{
			return Result.Success;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00003C74 File Offset: 0x00001E74
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x4C8DE0", Offset = "0x4C73E0", VA = "0x1804C8DE0")]
		public uint GetSessionAttributeCount(ref SessionDetailsGetSessionAttributeCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x4C8E60", Offset = "0x4C7460", VA = "0x1804C8E60")]
		public void Release()
		{
		}

		// Token: 0x040004B5 RID: 1205
		[Token(Token = "0x40004B5")]
		public const int SessiondetailsAttributeApiLatest = 1;

		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x40004B6")]
		public const int SessiondetailsCopyinfoApiLatest = 1;

		// Token: 0x040004B7 RID: 1207
		[Token(Token = "0x40004B7")]
		public const int SessiondetailsCopysessionattributebyindexApiLatest = 1;

		// Token: 0x040004B8 RID: 1208
		[Token(Token = "0x40004B8")]
		public const int SessiondetailsCopysessionattributebykeyApiLatest = 1;

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		public const int SessiondetailsGetsessionattributecountApiLatest = 1;

		// Token: 0x040004BA RID: 1210
		[Token(Token = "0x40004BA")]
		public const int SessiondetailsInfoApiLatest = 2;

		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40004BB")]
		public const int SessiondetailsSettingsApiLatest = 4;
	}
}
