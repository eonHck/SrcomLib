using SrcomLib.ApiObjects.ResponseObjects;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib
{
    internal interface IApi
    {
        Task<TApiObject> GetAsync<TApiObject>(Uri uri, CancellationToken cancellationToken);

        TApiObject Get<TApiObject>(Uri uri);

        Task<ApiResponseObject<TApiObject>> GetApiResponseObjectAsync<TApiObject>(Uri uri, CancellationToken cancellationToken);

        ApiResponseObject<TApiObject> GetApiResponseObject<TApiObject>(Uri uri);
    }
}