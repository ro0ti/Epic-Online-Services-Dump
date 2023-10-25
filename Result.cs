using System;
// Dumped by ro0ti

namespace Epic.OnlineServices
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	public enum Result
	{
		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		Success,
		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		NoConnection,
		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		InvalidCredentials,
		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		InvalidUser,
		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		InvalidAuth,
		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		AccessDenied,
		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		MissingPermissions,
		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		TokenNotAccount,
		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		TooManyRequests,
		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		AlreadyPending,
		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		InvalidParameters,
		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		InvalidRequest,
		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		UnrecognizedResponse,
		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		IncompatibleVersion,
		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		NotConfigured,
		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		AlreadyConfigured,
		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		NotImplemented,
		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		Canceled,
		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		NotFound,
		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		OperationWillRetry,
		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		NoChange,
		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		VersionMismatch,
		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		LimitExceeded,
		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		Disabled,
		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		DuplicateNotAllowed,
		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		MissingParametersDEPRECATED,
		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		InvalidSandboxId,
		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		TimedOut,
		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		PartialResult,
		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		MissingRole,
		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		MissingFeature,
		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		InvalidSandbox,
		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		InvalidDeployment,
		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		InvalidProduct,
		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		InvalidProductUserID,
		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		ServiceFailure,
		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		CacheDirectoryMissing,
		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		CacheDirectoryInvalid,
		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		InvalidState,
		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		RequestInProgress,
		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		ApplicationSuspended,
		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		NetworkDisconnected,
		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		AuthAccountLocked = 1001,
		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		AuthAccountLockedForUpdate,
		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		AuthInvalidRefreshToken,
		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		AuthInvalidToken,
		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		AuthAuthenticationFailure,
		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		AuthInvalidPlatformToken,
		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		AuthWrongAccount,
		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		AuthWrongClient,
		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		AuthFullAccountRequired,
		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		AuthHeadlessAccountRequired,
		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		AuthPasswordResetRequired,
		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		AuthPasswordCannotBeReused,
		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		AuthExpired,
		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		AuthScopeConsentRequired,
		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		AuthApplicationNotFound,
		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		AuthScopeNotFound,
		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		AuthAccountFeatureRestricted,
		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		AuthAccountPortalLoadError,
		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		AuthCorrectiveActionRequired,
		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		AuthPinGrantCode,
		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		AuthPinGrantExpired,
		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		AuthPinGrantPending,
		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		AuthExternalAuthNotLinked = 1030,
		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		AuthExternalAuthRevoked = 1032,
		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		AuthExternalAuthInvalid,
		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		AuthExternalAuthRestricted,
		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		AuthExternalAuthCannotLogin,
		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		AuthExternalAuthExpired,
		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		AuthExternalAuthIsLastLoginType,
		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		AuthExchangeCodeNotFound = 1040,
		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		AuthOriginatingExchangeCodeSessionExpired,
		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		AuthAccountNotActive = 1050,
		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		AuthMFARequired = 1060,
		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		AuthParentalControls = 1070,
		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		AuthNoRealId = 1080,
		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		AuthUserInterfaceRequired = 1090,
		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		FriendsInviteAwaitingAcceptance = 2000,
		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		FriendsNoInvitation,
		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		FriendsAlreadyFriends = 2003,
		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		FriendsNotFriends,
		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		FriendsTargetUserTooManyInvites,
		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		FriendsLocalUserTooManyInvites,
		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		FriendsTargetUserFriendLimitExceeded,
		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		FriendsLocalUserFriendLimitExceeded,
		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		PresenceDataInvalid = 3000,
		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		PresenceDataLengthInvalid,
		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		PresenceDataKeyInvalid,
		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		PresenceDataKeyLengthInvalid,
		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		PresenceDataValueInvalid,
		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		PresenceDataValueLengthInvalid,
		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		PresenceRichTextInvalid,
		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		PresenceRichTextLengthInvalid,
		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		PresenceStatusInvalid,
		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		EcomEntitlementStale = 4000,
		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		EcomCatalogOfferStale,
		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		EcomCatalogItemStale,
		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		EcomCatalogOfferPriceInvalid,
		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		EcomCheckoutLoadError,
		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		EcomPurchaseProcessing,
		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		SessionsSessionInProgress = 5000,
		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		SessionsTooManyPlayers,
		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		SessionsNoPermission,
		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		SessionsSessionAlreadyExists,
		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		SessionsInvalidLock,
		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		SessionsInvalidSession,
		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		SessionsSandboxNotAllowed,
		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		SessionsInviteFailed,
		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		SessionsInviteNotFound,
		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		SessionsUpsertNotAllowed,
		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		SessionsAggregationFailed,
		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		SessionsHostAtCapacity,
		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		SessionsSandboxAtCapacity,
		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		SessionsSessionNotAnonymous,
		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		SessionsOutOfSync,
		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		SessionsTooManyInvites,
		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		SessionsPresenceSessionExists,
		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		SessionsDeploymentAtCapacity,
		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		SessionsNotAllowed,
		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		SessionsPlayerSanctioned,
		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		PlayerDataStorageFilenameInvalid = 6000,
		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		PlayerDataStorageFilenameLengthInvalid,
		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		PlayerDataStorageFilenameInvalidChars,
		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		PlayerDataStorageFileSizeTooLarge,
		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		PlayerDataStorageFileSizeInvalid,
		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		PlayerDataStorageFileHandleInvalid,
		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		PlayerDataStorageDataInvalid,
		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		PlayerDataStorageDataLengthInvalid,
		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		PlayerDataStorageStartIndexInvalid,
		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		PlayerDataStorageRequestInProgress,
		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		PlayerDataStorageUserThrottled,
		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		PlayerDataStorageEncryptionKeyNotSet,
		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		PlayerDataStorageUserErrorFromDataCallback,
		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		PlayerDataStorageFileHeaderHasNewerVersion,
		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		PlayerDataStorageFileCorrupted,
		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		ConnectExternalTokenValidationFailed = 7000,
		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		ConnectUserAlreadyExists,
		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		ConnectAuthExpired,
		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		ConnectInvalidToken,
		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		ConnectUnsupportedTokenType,
		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		ConnectLinkAccountFailed,
		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		ConnectExternalServiceUnavailable,
		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		ConnectExternalServiceConfigurationFailure,
		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		ConnectLinkAccountFailedMissingNintendoIdAccountDEPRECATED,
		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		SocialOverlayLoadError = 8000,
		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		LobbyNotOwner = 9000,
		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		LobbyInvalidLock,
		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		LobbyLobbyAlreadyExists,
		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		LobbySessionInProgress,
		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		LobbyTooManyPlayers,
		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		LobbyNoPermission,
		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		LobbyInvalidSession,
		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		LobbySandboxNotAllowed,
		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		LobbyInviteFailed,
		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		LobbyInviteNotFound,
		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		LobbyUpsertNotAllowed,
		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		LobbyAggregationFailed,
		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		LobbyHostAtCapacity,
		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		LobbySandboxAtCapacity,
		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		LobbyTooManyInvites,
		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		LobbyDeploymentAtCapacity,
		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		LobbyNotAllowed,
		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		LobbyMemberUpdateOnly,
		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		LobbyPresenceLobbyExists,
		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		LobbyVoiceNotEnabled,
		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		LobbyPlatformNotAllowed,
		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		TitleStorageUserErrorFromDataCallback = 10000,
		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		TitleStorageEncryptionKeyNotSet,
		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		TitleStorageFileCorrupted,
		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		TitleStorageFileHeaderHasNewerVersion,
		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		ModsModSdkProcessIsAlreadyRunning = 11000,
		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		ModsModSdkCommandIsEmpty,
		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		ModsModSdkProcessCreationFailed,
		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		ModsCriticalError,
		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		ModsToolInternalError,
		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		ModsIPCFailure,
		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		ModsInvalidIPCResponse,
		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		ModsURILaunchFailure,
		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		ModsModIsNotInstalled,
		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		ModsUserDoesNotOwnTheGame,
		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		ModsOfferRequestByIdInvalidResult,
		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		ModsCouldNotFindOffer,
		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		ModsOfferRequestByIdFailure,
		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		ModsPurchaseFailure,
		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		ModsInvalidGameInstallInfo,
		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		ModsCannotGetManifestLocation,
		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		ModsUnsupportedOS,
		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		AntiCheatClientProtectionNotAvailable = 12000,
		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		AntiCheatInvalidMode,
		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		AntiCheatClientProductIdMismatch,
		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		AntiCheatClientSandboxIdMismatch,
		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		AntiCheatProtectMessageSessionKeyRequired,
		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		AntiCheatProtectMessageValidationFailed,
		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		AntiCheatProtectMessageInitializationFailed,
		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		AntiCheatPeerAlreadyRegistered,
		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		AntiCheatPeerNotFound,
		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		AntiCheatPeerNotProtected,
		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		AntiCheatClientDeploymentIdMismatch,
		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		AntiCheatDeviceIdAuthIsNotSupported,
		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		TooManyParticipants = 13000,
		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		RoomAlreadyExists,
		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		UserKicked,
		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		UserBanned,
		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		RoomWasLeft,
		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		ReconnectionTimegateExpired,
		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		ShutdownInvoked,
		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		UserIsInBlocklist,
		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		ProgressionSnapshotSnapshotIdUnavailable = 14000,
		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		ParentEmailMissing = 15000,
		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		UserGraduated,
		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		AndroidJavaVMNotStored = 17000,
		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		PermissionRequiredPatchAvailable = 18000,
		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		PermissionRequiredSystemUpdate,
		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		PermissionAgeRestrictionFailure,
		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		PermissionAccountTypeFailure,
		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		PermissionChatRestriction,
		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		PermissionUGCRestriction,
		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		PermissionOnlinePlayRestricted,
		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		DesktopCrossplayApplicationNotBootstrapped = 19000,
		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		DesktopCrossplayServiceNotInstalled,
		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		DesktopCrossplayServiceStartFailed,
		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		DesktopCrossplayServiceNotRunning,
		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		CustomInvitesInviteFailed = 20000,
		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		UserInfoBestDisplayNameIndeterminate = 22000,
		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		UnexpectedError = 2147483647
	}
}
