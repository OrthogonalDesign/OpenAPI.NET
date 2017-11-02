﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// ------------------------------------------------------------

using System;

namespace Microsoft.OpenApi.Models
{
    internal static class OpenApiConstants
    {
        public const string OpenApiDocOpenApi = "openapi";

        public const string OpenApiDocInfo = "info";

        public const string OpenApiDocTitle = "title";

        public const string OpenApiDocType = "type";

        public const string OpenApiDocFormat = "format";

        public const string OpenApiDocVersion = "version";

        public const string OpenApiDocContact = "contact";

        public const string OpenApiDocLicense = "license";

        public const string OpenApiDocTermsOfService = "termsOfService";

        public const string OpenApiDocServers = "servers";

        public const string OpenApiDocServer = "server";

        public const string OpenApiDocPaths = "paths";

        public const string OpenApiDocComponents = "components";

        public const string OpenApiDocSecurity = "security";

        public const string OpenApiDocTags = "tags";

        public const string OpenApiDocExternalDocs = "externalDocs";

        public const string OpenApiDocOperationRef = "operationRef";

        public const string OpenApiDocOperationId = "operationId";

        public const string OpenApiDocParameters = "parameters";

        public const string OpenApiDocRequestBody = "requestBody";

        public const string OpenApiDocExtensionFieldNamePrefix = "x-";

        public const string OpenApiDocName = "name";

        public const string OpenApiDocIn = "in";

        public const string OpenApiDocSummary = "summary";

        public const string OpenApiDocVariables = "variables";

        public const string OpenApiDocDescription = "description";

        public const string OpenApiDocRequired = "required";

        public const string OpenApiDocDeprecated = "deprecated";

        public const string OpenApiDocStyle = "style";

        public const string OpenApiDocExplode = "explode";

        public const string OpenApiDocAllowReserved = "allowReserved";

        public const string OpenApiDocSchema = "schema";

        public const string OpenApiDocSchemas = "schemas";

        public const string OpenApiDocResponses = "responses";

        public const string OpenApiDocExample = "example";

        public const string OpenApiDocExamples = "examples";

        public const string OpenApiDocEncoding = "encoding";

        public const string OpenApiDocRequestBodies = "requestBodies";

        public const string OpenApiDocAllowEmptyValue = "allowEmptyValue";

        public const string OpenApiDocValue = "value";

        public const string OpenApiDocExternalValue = "externalValue";

        public const string OpenApiDocDollarRef = "$ref";

        public const string OpenApiDocHeaders = "headers";

        public const string OpenApiDocSecuritySchemes = "securitySchemes";

        public const string OpenApiDocContent = "content";

        public const string OpenApiDocLinks = "links";

        public const string OpenApiDocCallbacks = "callbacks";

        public const string OpenApiDocUrl = "url";

        public const string OpenApiDocEmail = "email";

        public const string OpenApiDocDefault = "default";

        public const string OpenApiDocEnum = "enum";

        public const string OpenApiDocMultipleOf = "multipleOf";

        public const string OpenApiDocMaximum = "maximum";

        public const string OpenApiDocExclusiveMaximum = "exclusiveMaximum";

        public const string OpenApiDocMinimum = "minimum";

        public const string OpenApiDocExclusiveMinimum = "exclusiveMinimum";

        public const string OpenApiDocMaxLength = "maxLength";

        public const string OpenApiDocMinLength = "minLength";

        public const string OpenApiDocPattern = "pattern";

        public const string OpenApiDocMaxItems = "maxItems";

        public const string OpenApiDocMinItems = "minItems";

        public const string OpenApiDocUniqueItems = "uniqueItems";

        public const string OpenApiDocMaxProperties = "maxProperties";

        public const string OpenApiDocMinProperties = "minProperties";

        public const string OpenApiDocAllOf = "allOf";

        public const string OpenApiDocOneOf = "oneOf";

        public const string OpenApiDocAnyOf = "anyOf";

        public const string OpenApiDocNot = "not";

        public const string OpenApiDocItems = "items";

        public const string OpenApiDocProperties = "properties";

        public const string OpenApiDocAdditionalProperties = "additionalProperties";

        public const string OpenApiDocNullable = "nullable";

        public const string OpenApiDocDiscriminator = "discriminator";

        public const string OpenApiDocReadOnly = "readOnly";

        public const string OpenApiDocWriteOnly = "writeOnly";

        public const string OpenApiDocXml = "xml";

        public const string OpenApiDocFlow = "flow";

        public const string OpenApiDocApplication = "application";

        public const string OpenApiDocAccessCode = "accessCode";

        public const string OpenApiDocImplicit = "implicit";

        public const string OpenApiDocPassword = "password";

        public const string OpenApiDocClientCredentials = "clientCredentials";

        public const string OpenApiDocAuthorizationCode = "authorizationCode";

        public const string OpenApiDocAuthorizationUrl = "authorizationUrl";

        public const string OpenApiDocTokenUrl = "tokenUrl";

        public const string OpenApiDocRefreshUrl = "refreshUrl";

        public const string OpenApiDocScopes = "scopes";

        public const string OpenApiDocContentType = "contentType";

        public const string OpenApiDocGet = "get";

        public const string OpenApiDocPut = "put";

        public const string OpenApiDocPost = "post";

        public const string OpenApiDocDelete = "delete";

        public const string OpenApiDocOptions = "options";

        public const string OpenApiDocHead = "head";

        public const string OpenApiDocPatch = "patch";

        public const string OpenApiDocTrace = "trace";

        public const string OpenApiDocPropertyName = "propertyName";

        public const string OpenApiDocMapping = "mapping";

        public const string OpenApiDocScheme = "scheme";

        public const string OpenApiDocBearerFormat = "bearerFormat";

        public const string OpenApiDocFlows = "flows";

        public const string OpenApiDocOpenIdConnectUrl = "openIdConnectUrl";

        public const string OpenApiDocDefaultName = "Default Name";

        public const string OpenApiDocDefaultDefault = "Default Default";

        public const string OpenApiDocDefaultTitle = "Default Title";

        public static readonly Version OpenApiDocDefaultVersion = new Version(3, 0, 0);

        public static readonly Uri OpenApiDocDefaultUrl = new Uri("http://localhost/");

        public const string OpenApiDocDefaultDescription = "Default Description";

        #region V2
        public const string OpenApiDocHost = "host";

        public const string OpenApiDocSwagger = "swagger";

        public static readonly Version OpenApiDocSwaggerVersion = new Version(2, 0);

        public const string OpenApiDocBasePath = "basePath";

        public const string OpenApiDocSchemes = "schemes";

        public const string OpenApiDocSecurityDefinitions = "securityDefinitions";

        public const string OpenApiDocDefinitions = "definitions";

        public const string OpenApiDocBasic = "basic";

        public const string OpenApiDocConsumes = "consumes";

        public const string OpenApiDocProducts = "produces";

        #endregion
    }
}