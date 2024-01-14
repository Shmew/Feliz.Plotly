#!/bin/bash
set -e

CONTAINER_ALREADY_STARTED="CONTAINER_STARTED"

if [ ! -e $CONTAINER_ALREADY_STARTED ]; then
    dotnet tool restore
    dotnet paket install
    dotnet build

    sudo touch $CONTAINER_ALREADY_STARTED
fi

# Then exec the container's main process (what's set as CMD in the Dockerfile).
exec "$@"