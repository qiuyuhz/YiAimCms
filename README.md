
# ���ÿ�Խ
```
//1�������Խ����
private const string DefaultCorsPolicyName = "Default";
//2���� ConfigureServices ʹ��
ConfigureCors(context, configuration);
//3����OnApplicationInitialization ���� app.UseRouting()֮�� app.UseAuthentication()֮ǰ����
app.UseCors(DefaultCorsPolicyName);

private void ConfigureCors(ServiceConfigurationContext context, IConfiguration configuration)
    {
        context.Services.AddCors(options =>
        {
            options.AddPolicy(DefaultCorsPolicyName, builder =>
            {
                builder
                    .WithOrigins(
                        configuration["App:CorsOrigins"]
                            .Split(",", StringSplitOptions.RemoveEmptyEntries)
                            .Select(o => o.RemovePostFix("/"))
                            .ToArray()
                    )
                    .WithAbpExposedHeaders()
                    .SetIsOriginAllowedToAllowWildcardSubdomains()
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
            });
        });
    }
```
# ABP����Ȩģ��
> ���Բο���IdentityServer4����������ABPģ����Ŀ����һ��IdentityServer4�����ĵ���uri�ǣ�/.well-known/openid-configuration

# ���ڳ������ݳ�ʼ��
��Ӧ��abpvnext��ܵĵ������ʱ����Ҫ��ʼ��������ܵ�admin����Ա��Ϣ���ͻ�����֤�������Ϣ�����û����ؿͻ�����֤��Ϣ�������ڷ��ʣ�
�ӿڵ�ַ��https://localhost:XXXX/connect/tokenʱ�ͻᱨ��
��error: "invalid_client"
>  ���������ȡTokenʱ��"invalid_client"

��ȡToken:
1���ӿڵ�ַ��https://localhost:44349/connect/token
2���ӿ���Ҫ�ԣ�application/x-www-form-urlencoded �ķ�ʽ���ã�
3���ӿڲ�����

- Ĭ�Ϲ���Ա�˺� Ĭ���û�����admin��Ĭ��������1q2w3E* 

> ����ʹ�� ʹ�ýӿ�/connect/token ��¼�ɹ�������