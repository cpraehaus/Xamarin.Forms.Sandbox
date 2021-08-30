$SolDir = $PSScriptRoot
Echo "Cleaning up dir $SolDir"
gci -inc bin,obj -rec $SolDir | rm -rec -force

