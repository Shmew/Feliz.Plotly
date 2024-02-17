#!/bin/bash
set -e

CONTAINER_ALREADY_STARTED="CONTAINER_STARTED"

# one-time startup commands here
if [ ! -e $CONTAINER_ALREADY_STARTED ]; then
    dotnet tool restore
    dotnet paket restore
    # dotnet paket install
    # dotnet build

    sudo touch $CONTAINER_ALREADY_STARTED
fi

# Then exec the container's main process (what's set as CMD in the Dockerfile).
exec "$@"