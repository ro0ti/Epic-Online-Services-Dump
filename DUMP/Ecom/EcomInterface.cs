using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200054C RID: 1356
	[Token(Token = "0x200054C")]
	public sealed class EcomInterface : Handle
	{
		// Token: 0x06002300 RID: 8960 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002300")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public EcomInterface()
		{
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002301")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public EcomInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002302")]
		[Address(RVA = "0x541FD0", Offset = "0x5405D0", VA = "0x180541FD0")]
		public void Checkout(ref CheckoutOptions options, object clientData, OnCheckoutCallback completionDelegate)
		{
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x00009374 File Offset: 0x00007574
		[Token(Token = "0x6002303")]
		[Address(RVA = "0x5421A0", Offset = "0x5407A0", VA = "0x1805421A0")]
		public Result CopyEntitlementById(ref CopyEntitlementByIdOptions options, out Entitlement? outEntitlement)
		{
			return Result.Success;
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x0000938C File Offset: 0x0000758C
		[Token(Token = "0x6002304")]
		[Address(RVA = "0x5422A0", Offset = "0x5408A0", VA = "0x1805422A0")]
		public Result CopyEntitlementByIndex(ref CopyEntitlementByIndexOptions options, out Entitlement? outEntitlement)
		{
			return Result.Success;
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x000093A4 File Offset: 0x000075A4
		[Token(Token = "0x6002305")]
		[Address(RVA = "0x5423F0", Offset = "0x5409F0", VA = "0x1805423F0")]
		public Result CopyEntitlementByNameAndIndex(ref CopyEntitlementByNameAndIndexOptions options, out Entitlement? outEntitlement)
		{
			return Result.Success;
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x000093BC File Offset: 0x000075BC
		[Token(Token = "0x6002306")]
		[Address(RVA = "0x5424F0", Offset = "0x540AF0", VA = "0x1805424F0")]
		public Result CopyItemById(ref CopyItemByIdOptions options, out CatalogItem? outItem)
		{
			return Result.Success;
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x000093D4 File Offset: 0x000075D4
		[Token(Token = "0x6002307")]
		[Address(RVA = "0x5425F0", Offset = "0x540BF0", VA = "0x1805425F0")]
		public Result CopyItemImageInfoByIndex(ref CopyItemImageInfoByIndexOptions options, out KeyImageInfo? outImageInfo)
		{
			return Result.Success;
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x000093EC File Offset: 0x000075EC
		[Token(Token = "0x6002308")]
		[Address(RVA = "0x5426F0", Offset = "0x540CF0", VA = "0x1805426F0")]
		public Result CopyItemReleaseByIndex(ref CopyItemReleaseByIndexOptions options, out CatalogRelease? outRelease)
		{
			return Result.Success;
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x00009404 File Offset: 0x00007604
		[Token(Token = "0x6002309")]
		[Address(RVA = "0x5427F0", Offset = "0x540DF0", VA = "0x1805427F0")]
		public Result CopyLastRedeemedEntitlementByIndex(ref CopyLastRedeemedEntitlementByIndexOptions options, out Utf8String outRedeemedEntitlementId)
		{
			return Result.Success;
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x0000941C File Offset: 0x0000761C
		[Token(Token = "0x600230A")]
		[Address(RVA = "0x542920", Offset = "0x540F20", VA = "0x180542920")]
		public Result CopyOfferById(ref CopyOfferByIdOptions options, out CatalogOffer? outOffer)
		{
			return Result.Success;
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x00009434 File Offset: 0x00007634
		[Token(Token = "0x600230B")]
		[Address(RVA = "0x542A20", Offset = "0x541020", VA = "0x180542A20")]
		public Result CopyOfferByIndex(ref CopyOfferByIndexOptions options, out CatalogOffer? outOffer)
		{
			return Result.Success;
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x0000944C File Offset: 0x0000764C
		[Token(Token = "0x600230C")]
		[Address(RVA = "0x542B70", Offset = "0x541170", VA = "0x180542B70")]
		public Result CopyOfferImageInfoByIndex(ref CopyOfferImageInfoByIndexOptions options, out KeyImageInfo? outImageInfo)
		{
			return Result.Success;
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x00009464 File Offset: 0x00007664
		[Token(Token = "0x600230D")]
		[Address(RVA = "0x542C70", Offset = "0x541270", VA = "0x180542C70")]
		public Result CopyOfferItemByIndex(ref CopyOfferItemByIndexOptions options, out CatalogItem? outItem)
		{
			return Result.Success;
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x0000947C File Offset: 0x0000767C
		[Token(Token = "0x600230E")]
		[Address(RVA = "0x542D70", Offset = "0x541370", VA = "0x180542D70")]
		public Result CopyTransactionById(ref CopyTransactionByIdOptions options, out Transaction outTransaction)
		{
			return Result.Success;
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x00009494 File Offset: 0x00007694
		[Token(Token = "0x600230F")]
		[Address(RVA = "0x542E50", Offset = "0x541450", VA = "0x180542E50")]
		public Result CopyTransactionByIndex(ref CopyTransactionByIndexOptions options, out Transaction outTransaction)
		{
			return Result.Success;
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x000094AC File Offset: 0x000076AC
		[Token(Token = "0x6002310")]
		[Address(RVA = "0x542F80", Offset = "0x541580", VA = "0x180542F80")]
		public uint GetEntitlementsByNameCount(ref GetEntitlementsByNameCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x000094C4 File Offset: 0x000076C4
		[Token(Token = "0x6002311")]
		[Address(RVA = "0x543020", Offset = "0x541620", VA = "0x180543020")]
		public uint GetEntitlementsCount(ref GetEntitlementsCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x000094DC File Offset: 0x000076DC
		[Token(Token = "0x6002312")]
		[Address(RVA = "0x543100", Offset = "0x541700", VA = "0x180543100")]
		public uint GetItemImageInfoCount(ref GetItemImageInfoCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x000094F4 File Offset: 0x000076F4
		[Token(Token = "0x6002313")]
		[Address(RVA = "0x5431A0", Offset = "0x5417A0", VA = "0x1805431A0")]
		public uint GetItemReleaseCount(ref GetItemReleaseCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x0000950C File Offset: 0x0000770C
		[Token(Token = "0x6002314")]
		[Address(RVA = "0x543240", Offset = "0x541840", VA = "0x180543240")]
		public uint GetLastRedeemedEntitlementsCount(ref GetLastRedeemedEntitlementsCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x00009524 File Offset: 0x00007724
		[Token(Token = "0x6002315")]
		[Address(RVA = "0x543320", Offset = "0x541920", VA = "0x180543320")]
		public uint GetOfferCount(ref GetOfferCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x0000953C File Offset: 0x0000773C
		[Token(Token = "0x6002316")]
		[Address(RVA = "0x543400", Offset = "0x541A00", VA = "0x180543400")]
		public uint GetOfferImageInfoCount(ref GetOfferImageInfoCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x00009554 File Offset: 0x00007754
		[Token(Token = "0x6002317")]
		[Address(RVA = "0x5434A0", Offset = "0x541AA0", VA = "0x1805434A0")]
		public uint GetOfferItemCount(ref GetOfferItemCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x0000956C File Offset: 0x0000776C
		[Token(Token = "0x6002318")]
		[Address(RVA = "0x543540", Offset = "0x541B40", VA = "0x180543540")]
		public uint GetTransactionCount(ref GetTransactionCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002319")]
		[Address(RVA = "0x543B20", Offset = "0x542120", VA = "0x180543B20")]
		public void QueryEntitlementToken(ref QueryEntitlementTokenOptions options, object clientData, OnQueryEntitlementTokenCallback completionDelegate)
		{
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600231A")]
		[Address(RVA = "0x543D80", Offset = "0x542380", VA = "0x180543D80")]
		public void QueryEntitlements(ref QueryEntitlementsOptions options, object clientData, OnQueryEntitlementsCallback completionDelegate)
		{
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600231B")]
		[Address(RVA = "0x543F50", Offset = "0x542550", VA = "0x180543F50")]
		public void QueryOffers(ref QueryOffersOptions options, object clientData, OnQueryOffersCallback completionDelegate)
		{
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600231C")]
		[Address(RVA = "0x544550", Offset = "0x542B50", VA = "0x180544550")]
		public void QueryOwnership(ref QueryOwnershipOptions options, object clientData, OnQueryOwnershipCallback completionDelegate)
		{
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600231D")]
		[Address(RVA = "0x544120", Offset = "0x542720", VA = "0x180544120")]
		public void QueryOwnershipBySandboxIds(ref QueryOwnershipBySandboxIdsOptions options, object clientData, OnQueryOwnershipBySandboxIdsCallback completionDelegate)
		{
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600231E")]
		[Address(RVA = "0x544380", Offset = "0x542980", VA = "0x180544380")]
		public void QueryOwnershipToken(ref QueryOwnershipTokenOptions options, object clientData, OnQueryOwnershipTokenCallback completionDelegate)
		{
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600231F")]
		[Address(RVA = "0x544720", Offset = "0x542D20", VA = "0x180544720")]
		public void RedeemEntitlements(ref RedeemEntitlementsOptions options, object clientData, OnRedeemEntitlementsCallback completionDelegate)
		{
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002320")]
		[Address(RVA = "0x543620", Offset = "0x541C20", VA = "0x180543620")]
		[MonoPInvokeCallback(typeof(OnCheckoutCallbackInternal))]
		internal static void OnCheckoutCallbackInternalImplementation(ref CheckoutCallbackInfoInternal data)
		{
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002321")]
		[Address(RVA = "0x5436C0", Offset = "0x541CC0", VA = "0x1805436C0")]
		[MonoPInvokeCallback(typeof(OnQueryEntitlementTokenCallbackInternal))]
		internal static void OnQueryEntitlementTokenCallbackInternalImplementation(ref QueryEntitlementTokenCallbackInfoInternal data)
		{
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002322")]
		[Address(RVA = "0x543760", Offset = "0x541D60", VA = "0x180543760")]
		[MonoPInvokeCallback(typeof(OnQueryEntitlementsCallbackInternal))]
		internal static void OnQueryEntitlementsCallbackInternalImplementation(ref QueryEntitlementsCallbackInfoInternal data)
		{
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002323")]
		[Address(RVA = "0x543800", Offset = "0x541E00", VA = "0x180543800")]
		[MonoPInvokeCallback(typeof(OnQueryOffersCallbackInternal))]
		internal static void OnQueryOffersCallbackInternalImplementation(ref QueryOffersCallbackInfoInternal data)
		{
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002324")]
		[Address(RVA = "0x5438A0", Offset = "0x541EA0", VA = "0x1805438A0")]
		[MonoPInvokeCallback(typeof(OnQueryOwnershipBySandboxIdsCallbackInternal))]
		internal static void OnQueryOwnershipBySandboxIdsCallbackInternalImplementation(ref QueryOwnershipBySandboxIdsCallbackInfoInternal data)
		{
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002325")]
		[Address(RVA = "0x543940", Offset = "0x541F40", VA = "0x180543940")]
		[MonoPInvokeCallback(typeof(OnQueryOwnershipCallbackInternal))]
		internal static void OnQueryOwnershipCallbackInternalImplementation(ref QueryOwnershipCallbackInfoInternal data)
		{
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002326")]
		[Address(RVA = "0x5439E0", Offset = "0x541FE0", VA = "0x1805439E0")]
		[MonoPInvokeCallback(typeof(OnQueryOwnershipTokenCallbackInternal))]
		internal static void OnQueryOwnershipTokenCallbackInternalImplementation(ref QueryOwnershipTokenCallbackInfoInternal data)
		{
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002327")]
		[Address(RVA = "0x543A80", Offset = "0x542080", VA = "0x180543A80")]
		[MonoPInvokeCallback(typeof(OnRedeemEntitlementsCallbackInternal))]
		internal static void OnRedeemEntitlementsCallbackInternalImplementation(ref RedeemEntitlementsCallbackInfoInternal data)
		{
		}

		// Token: 0x04000F79 RID: 3961
		[Token(Token = "0x4000F79")]
		public const int CatalogitemApiLatest = 1;

		// Token: 0x04000F7A RID: 3962
		[Token(Token = "0x4000F7A")]
		public const int CatalogitemEntitlementendtimestampUndefined = -1;

		// Token: 0x04000F7B RID: 3963
		[Token(Token = "0x4000F7B")]
		public const int CatalogofferApiLatest = 5;

		// Token: 0x04000F7C RID: 3964
		[Token(Token = "0x4000F7C")]
		public const int CatalogofferEffectivedatetimestampUndefined = -1;

		// Token: 0x04000F7D RID: 3965
		[Token(Token = "0x4000F7D")]
		public const int CatalogofferExpirationtimestampUndefined = -1;

		// Token: 0x04000F7E RID: 3966
		[Token(Token = "0x4000F7E")]
		public const int CatalogofferReleasedatetimestampUndefined = -1;

		// Token: 0x04000F7F RID: 3967
		[Token(Token = "0x4000F7F")]
		public const int CatalogreleaseApiLatest = 1;

		// Token: 0x04000F80 RID: 3968
		[Token(Token = "0x4000F80")]
		public const int CheckoutApiLatest = 1;

		// Token: 0x04000F81 RID: 3969
		[Token(Token = "0x4000F81")]
		public const int CheckoutMaxEntries = 10;

		// Token: 0x04000F82 RID: 3970
		[Token(Token = "0x4000F82")]
		public const int CheckoutentryApiLatest = 1;

		// Token: 0x04000F83 RID: 3971
		[Token(Token = "0x4000F83")]
		public const int CopyentitlementbyidApiLatest = 2;

		// Token: 0x04000F84 RID: 3972
		[Token(Token = "0x4000F84")]
		public const int CopyentitlementbyindexApiLatest = 1;

		// Token: 0x04000F85 RID: 3973
		[Token(Token = "0x4000F85")]
		public const int CopyentitlementbynameandindexApiLatest = 1;

		// Token: 0x04000F86 RID: 3974
		[Token(Token = "0x4000F86")]
		public const int CopyitembyidApiLatest = 1;

		// Token: 0x04000F87 RID: 3975
		[Token(Token = "0x4000F87")]
		public const int CopyitemimageinfobyindexApiLatest = 1;

		// Token: 0x04000F88 RID: 3976
		[Token(Token = "0x4000F88")]
		public const int CopyitemreleasebyindexApiLatest = 1;

		// Token: 0x04000F89 RID: 3977
		[Token(Token = "0x4000F89")]
		public const int CopylastredeemedentitlementbyindexApiLatest = 1;

		// Token: 0x04000F8A RID: 3978
		[Token(Token = "0x4000F8A")]
		public const int CopyofferbyidApiLatest = 3;

		// Token: 0x04000F8B RID: 3979
		[Token(Token = "0x4000F8B")]
		public const int CopyofferbyindexApiLatest = 3;

		// Token: 0x04000F8C RID: 3980
		[Token(Token = "0x4000F8C")]
		public const int CopyofferimageinfobyindexApiLatest = 1;

		// Token: 0x04000F8D RID: 3981
		[Token(Token = "0x4000F8D")]
		public const int CopyofferitembyindexApiLatest = 1;

		// Token: 0x04000F8E RID: 3982
		[Token(Token = "0x4000F8E")]
		public const int CopytransactionbyidApiLatest = 1;

		// Token: 0x04000F8F RID: 3983
		[Token(Token = "0x4000F8F")]
		public const int CopytransactionbyindexApiLatest = 1;

		// Token: 0x04000F90 RID: 3984
		[Token(Token = "0x4000F90")]
		public const int EntitlementApiLatest = 2;

		// Token: 0x04000F91 RID: 3985
		[Token(Token = "0x4000F91")]
		public const int EntitlementEndtimestampUndefined = -1;

		// Token: 0x04000F92 RID: 3986
		[Token(Token = "0x4000F92")]
		public const int EntitlementidMaxLength = 32;

		// Token: 0x04000F93 RID: 3987
		[Token(Token = "0x4000F93")]
		public const int GetentitlementsbynamecountApiLatest = 1;

		// Token: 0x04000F94 RID: 3988
		[Token(Token = "0x4000F94")]
		public const int GetentitlementscountApiLatest = 1;

		// Token: 0x04000F95 RID: 3989
		[Token(Token = "0x4000F95")]
		public const int GetitemimageinfocountApiLatest = 1;

		// Token: 0x04000F96 RID: 3990
		[Token(Token = "0x4000F96")]
		public const int GetitemreleasecountApiLatest = 1;

		// Token: 0x04000F97 RID: 3991
		[Token(Token = "0x4000F97")]
		public const int GetlastredeemedentitlementscountApiLatest = 1;

		// Token: 0x04000F98 RID: 3992
		[Token(Token = "0x4000F98")]
		public const int GetoffercountApiLatest = 1;

		// Token: 0x04000F99 RID: 3993
		[Token(Token = "0x4000F99")]
		public const int GetofferimageinfocountApiLatest = 1;

		// Token: 0x04000F9A RID: 3994
		[Token(Token = "0x4000F9A")]
		public const int GetofferitemcountApiLatest = 1;

		// Token: 0x04000F9B RID: 3995
		[Token(Token = "0x4000F9B")]
		public const int GettransactioncountApiLatest = 1;

		// Token: 0x04000F9C RID: 3996
		[Token(Token = "0x4000F9C")]
		public const int ItemownershipApiLatest = 1;

		// Token: 0x04000F9D RID: 3997
		[Token(Token = "0x4000F9D")]
		public const int KeyimageinfoApiLatest = 1;

		// Token: 0x04000F9E RID: 3998
		[Token(Token = "0x4000F9E")]
		public const int QueryentitlementsApiLatest = 2;

		// Token: 0x04000F9F RID: 3999
		[Token(Token = "0x4000F9F")]
		public const int QueryentitlementsMaxEntitlementIds = 256;

		// Token: 0x04000FA0 RID: 4000
		[Token(Token = "0x4000FA0")]
		public const int QueryentitlementtokenApiLatest = 1;

		// Token: 0x04000FA1 RID: 4001
		[Token(Token = "0x4000FA1")]
		public const int QueryentitlementtokenMaxEntitlementIds = 32;

		// Token: 0x04000FA2 RID: 4002
		[Token(Token = "0x4000FA2")]
		public const int QueryoffersApiLatest = 1;

		// Token: 0x04000FA3 RID: 4003
		[Token(Token = "0x4000FA3")]
		public const int QueryownershipApiLatest = 2;

		// Token: 0x04000FA4 RID: 4004
		[Token(Token = "0x4000FA4")]
		public const int QueryownershipMaxCatalogIds = 400;

		// Token: 0x04000FA5 RID: 4005
		[Token(Token = "0x4000FA5")]
		public const int QueryownershipMaxSandboxIds = 10;

		// Token: 0x04000FA6 RID: 4006
		[Token(Token = "0x4000FA6")]
		public const int QueryownershipbysandboxidsoptionsApiLatest = 1;

		// Token: 0x04000FA7 RID: 4007
		[Token(Token = "0x4000FA7")]
		public const int QueryownershiptokenApiLatest = 2;

		// Token: 0x04000FA8 RID: 4008
		[Token(Token = "0x4000FA8")]
		public const int QueryownershiptokenMaxCatalogitemIds = 32;

		// Token: 0x04000FA9 RID: 4009
		[Token(Token = "0x4000FA9")]
		public const int RedeementitlementsApiLatest = 2;

		// Token: 0x04000FAA RID: 4010
		[Token(Token = "0x4000FAA")]
		public const int RedeementitlementsMaxIds = 32;

		// Token: 0x04000FAB RID: 4011
		[Token(Token = "0x4000FAB")]
		public const int TransactionidMaximumLength = 64;
	}
}
