// Abblix OIDC Server Library
// Copyright (c) Abblix LLP. All rights reserved.
// 
// DISCLAIMER: This software is provided 'as-is', without any express or implied
// warranty. Use at your own risk. Abblix LLP is not liable for any damages
// arising from the use of this software.
// 
// LICENSE RESTRICTIONS: This code may not be modified, copied, or redistributed
// in any form outside of the official GitHub repository at:
// https://github.com/Abblix/OIDC.Server. All development and modifications
// must occur within the official repository and are managed solely by Abblix LLP.
// 
// Unauthorized use, modification, or distribution of this software is strictly
// prohibited and may be subject to legal action.
// 
// For full licensing terms, please visit:
// 
// https://oidc.abblix.com/license
// 
// CONTACT: For license inquiries or permissions, contact Abblix LLP at
// info@abblix.com

namespace Abblix.Oidc.Server.UnitTests.Controllers;

public class DiscoveryUnitTests
{
	//[DataTestMethod]
	//[TestCase(ResponseTypes.None, "\"none\"")]
	//[TestCase(ResponseTypes.IdToken, "\"id_token\"")]
	//[TestCase(ResponseTypes.IdToken | ResponseTypes.Token, "\"token id_token\"")]
	//public void FlagsEnumStringConverterTest(string[] source, string expected)
	//{
	//	var options = new JsonSerializerOptions { Converters = { new EnumStringConverter() } };
	//	var json = JsonSerializer.Serialize(source, options);
	//	Assert.AreEqual(expected, json);

	//	var deserialized = JsonSerializer.Deserialize<ResponseTypes>(json, options);
	//	Assert.AreEqual(source, deserialized);
	//}

	//[DataTestMethod]
	//[TestCase(GrantType.AuthorizationCode, "\"authorization_code\"")]
	//[TestCase(GrantType.ClientCredentials, "\"client_credentials\"")]
	//[TestCase(GrantType.RefreshToken, "\"refresh_token\"")]
	//[TestCase(GrantType.Implicit, "\"implicit\"")]
	//[TestCase(GrantType.Password, "\"password\"")]
	//public void EnumStringConverterTest(GrantType source, string expected)
	//{
	//	var options = new JsonSerializerOptions { Converters = { new EnumStringConverter() } };
	//	var json = JsonSerializer.Serialize(source, options);
	//	Assert.AreEqual(expected, json);

	//	var deserialized = JsonSerializer.Deserialize<GrantType>(json, options);
	//	Assert.AreEqual(source, deserialized);
	//}
}
