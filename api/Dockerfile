FROM microsoft/aspnetcore-build:2.0.2
COPY ./rift.csproj /app/rift.csproj
WORKDIR /app
RUN ["dotnet", "restore"]
# RUN ["rm", "obj"]
# COPY ./out/* /app/
# EXPOSE 4500/tcp
# RUN ["dotnet", "rift.dll"]
# ENTRYPOINT ["dotnet", "run"]
ENTRYPOINT [ "dotnet", "run" ]
# RUN ["dotnet", "run"]
# RUN chmod +x ./entrypoint.sh
# CMD /bin/bash ./entrypoint.sh