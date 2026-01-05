# AspireCosmos

Demo of cosmos db connection not working in 13.1

Plug your Azure subscription details into user secrets on the apphost, let it spin up the azure resources. You'll see the API fail to start:

> Waiting for resource 'secrets' to enter the 'Running' state.
> Waiting for resource ready to execute for 'secrets'.
> Finished waiting for resource 'secrets'.
> Waiting for value for connection string from resource 'cosmosDatabase'
> Waiting for value from Aspire.Hosting.ApplicationModel.ReferenceExpression.
> Waiting for value from Aspire.Hosting.ApplicationModel.ReferenceExpression.


<img width="1242" height="551" alt="image" src="https://github.com/user-attachments/assets/2bf425a2-5327-4e56-8fee-f9c94486223b" />

<img width="702" height="314" alt="image" src="https://github.com/user-attachments/assets/ee2c42c2-0469-4467-8932-78351e3b528a" />
