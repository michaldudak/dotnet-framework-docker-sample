FROM michaldudak/asp-iis

RUN powershell -Command Remove-Item C:\inetpub\wwwroot\* -Recurse -Force

WORKDIR /inetpub/wwwroot
COPY ./NetFrameworkWebApp .

ENTRYPOINT powershell