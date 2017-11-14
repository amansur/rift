FROM microsoft/aspnetcore-build:2.0.2
COPY rift.csproj /api/
WORKDIR /api
RUN ["dotnet", "restore"]
ENTRYPOINT [ "dotnet", "run" ]