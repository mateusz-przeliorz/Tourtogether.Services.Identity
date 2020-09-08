#!/bin/bash
export ASPNETCORE_ENVIRONMENT=local
cd src/Tourtogether.Services.Identity.Api
dotnet watch run --no-restore