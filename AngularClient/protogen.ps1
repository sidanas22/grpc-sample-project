# $PROTOC_GEN_TS_PATH = "$($PWD)\node_modules\.bin\protoc-gen-ts.cmd"

# $PROTOC_OUT_DIR = "$($PWD)\src\app\core"

# $PROTOC_FILE_NAMES = $args

# protoc --plugin="protoc-gen-ts=$PROTOC_GEN_TS_PATH" --js_out="import_style=commonjs,binary:$PROTOC_OUT_DIR" --ts_out="service=grpc-web:$PROTOC_OUT_DIR" grpc-models/$PROTOC_FILE_NAMES


$PROTOC_GEN_TS_PATH = "$($PWD)\node_modules\.bin\protoc-gen-ts.cmd"
$PROTOC_OUT_DIR = "$($PWD)\src\app\core"

foreach ($file in $args) {
    protoc --plugin="protoc-gen-ts=$PROTOC_GEN_TS_PATH" --js_out="import_style=commonjs,binary:$PROTOC_OUT_DIR" --ts_out="service=grpc-web:$PROTOC_OUT_DIR" "grpc-models/$file"
}