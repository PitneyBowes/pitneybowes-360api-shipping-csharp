# com.pitneybowes.api360.Api.DefaultsApi

All URIs are relative to *https://api-dev.sendpro360.pitneycloud.com/shipping*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateDefaults**](DefaultsApi.md#createdefaults) | **POST** /api/v1/defaults | Create Defaults |
| [**DeleteDefaultsById**](DefaultsApi.md#deletedefaultsbyid) | **DELETE** /api/v1/defaults/{defaultID} | Delete Defaults by ID |
| [**GetAllDefaults**](DefaultsApi.md#getalldefaults) | **GET** /api/v1/defaults | Get All Defaults |
| [**GetDefaultsById**](DefaultsApi.md#getdefaultsbyid) | **GET** /api/v1/defaults/{defaultID} | Get Defaults By ID |
| [**PutDefaultsById**](DefaultsApi.md#putdefaultsbyid) | **PUT** /api/v1/defaults/{defaultID} | Update Defaults |

<a id="createdefaults"></a>
# **CreateDefaults**
> CreateDefaultsResponse CreateDefaults (CreateDefaults createDefaults)

Create Defaults

While creating shipment, a few columns/ fields information are used mandatorily, and if the value for those columns are used repetitively, then it is always better to save last used values. And hence, this API has been introduced. Using this API, default values can be set up for frequently used columns/fields information like carrier, its linked services, and special services.  Setting up the defaults will save both time and efforts. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDefaults** | [**CreateDefaults**](CreateDefaults.md) |  |  |

### Return type

[**CreateDefaultsResponse**](CreateDefaultsResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Defaults (i.e., default values) have been created successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletedefaultsbyid"></a>
# **DeleteDefaultsById**
> void DeleteDefaultsById (string defaultID)

Delete Defaults by ID

This operation deletes the existing Defaults.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **defaultID** | **string** | This is unique identifier assigned to Defaults while its creation using CreateDefaults API. |  |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Defaults (i.e., default values) have been deleted successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getalldefaults"></a>
# **GetAllDefaults**
> AllDefaults GetAllDefaults (string xPBDeveloperPartnerID = null, string page = null, string size = null)

Get All Defaults

The operation fetches all created Defaults. If query parameters are not provided, it will consider default page as 1 and default size as 10.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerID** | **string** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |
| **page** | **string** | The page of the Defaults search result list. | [optional]  |
| **size** | **string** | The size/count of the searched result list. | [optional]  |

### Return type

[**AllDefaults**](AllDefaults.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Defaults. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdefaultsbyid"></a>
# **GetDefaultsById**
> DefaultResponse GetDefaultsById (string defaultID)

Get Defaults By ID

This operation fetches the values set for the Defaults.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **defaultID** | **string** | This is unique identifier assigned to Defaults while its creation using CreateDefaults API. |  |

### Return type

[**DefaultResponse**](DefaultResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Defaults values have been retrieved successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="putdefaultsbyid"></a>
# **PutDefaultsById**
> void PutDefaultsById (string defaultID, CreateDefaults createDefaults)

Update Defaults

This operation updates the values set for Defaults.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **defaultID** | **string** | This is unique identifier assigned to Defaults while its creation using CreateDefaults API. |  |
| **createDefaults** | [**CreateDefaults**](CreateDefaults.md) |  |  |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Defaults (i.e., default values) have been updated successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

