# Comments in docker file
# Docker file is the recipe for buildg your docker image


# General things before you do in a dockerfile
# 1. choose the base image : you can get your base image (a) locally (b) from registry (docker hub)
# 2. copy files from outside the image into the image
# 3. run terminal commands inside the image (eg: installing things)
# 4. add configuration/environmental variables if requeired


# to set the base image we do this
#   Registry        repo/image      tag
#  (by default) (dockerhub)     (latest)
#      |        |               |
FROM mcr.microsoft.com/dotnet/sdk:6.0


# the runtime needs assemblies already compiled
# so before "docker build", run:
RUN dotnet publish -o publish

# take the contents of the published folder outside dockert...
# ... out them in a new folder /app at the root of the docker's file system
COPY publish/ /app

# after building the image, we can run container's app like:
# docker run "docker container name" or "docker SHA" //app/Practice.dll
# replacing the docker's SHA with your image's HASH

# we can configure the image with default command to startup with
CMD dotnet /app/Practice.dll