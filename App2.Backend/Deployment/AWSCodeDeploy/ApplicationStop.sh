#!/bin/bash

command="systemctl is-active --quiet kestrel-App2.service && systemctl stop kestrel-App2.service"
eval " $command"

command="systemctl is-enabled --quiet kestrel-App2.service && systemctl disable kestrel-App2.service"
eval " $command"