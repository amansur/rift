FROM microsoft/aspnetcore-build:2.0.2
WORKDIR /app
COPY ./rift.csproj /app/rift.csproj
# COPY . /app
RUN ["dotnet", "restore"]
COPY ./out/* /app/
EXPOSE 5000/tcp
RUN ["dotnet", "rift.dll"]
# RUN ["dotnet", "build"]
# RUN ["dotnet", "run"]
# RUN chmod +x ./entrypoint.sh
# CMD /bin/bash ./entrypoint.sh