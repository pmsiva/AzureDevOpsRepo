#!/bin/bash

systemctl is-active --quiet kestrel-App2.service && systemctl stop kestrel-App2.service
systemctl is-enabled --quiet kestrel-App2.service && systemctl disable kestrel-App2.service
