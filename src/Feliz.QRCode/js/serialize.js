export function SerializeSVGElement(node) {
    print(node);
    const s = new XMLSerializer();
    return s.serializeToString(node);
}
