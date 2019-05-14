#!/bin/bash


command="systemctl enable kestrel-App2.service"
eval " $command"

command="systemctl start kestrel-App2.service"
eval " $command"