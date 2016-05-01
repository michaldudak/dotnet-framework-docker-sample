FROM michaldudak/asp-iis

RUN mkdir WebApp

COPY ./NetFrameworkWebApp /WebApp
WORKDIR /WebApp

RUN powershell New-WebApplication -Site 'Default Web Site' -ApplicationPool 'DefaultAppPool' -Name 'WebApp' -PhysicalPath 'C:\WebApp'

ENTRYPOINT powershell