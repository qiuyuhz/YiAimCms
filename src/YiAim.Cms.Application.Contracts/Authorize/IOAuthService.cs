﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace YiAim.Cms.Authorize
{
    public interface IOAuthService<TAccessToke, TUserInfo>
    {
        /// <summary>
        /// 获取登录地址(GitHub)
        /// </summary>
        /// <returns></returns>
        Task<string> GetAuthorizeUrl(string state);
      
        /// <summary>
        /// 获取AccessToken
        /// </summary>
        /// <param name="code"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        Task<TAccessToke> GetAccessTokenAsync(string code, string state);
    }
}
