
package ws;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the ws package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _NombreCompletoResponse_QNAME = new QName("http://ws/", "nombreCompletoResponse");
    private final static QName _NombreCompleto_QNAME = new QName("http://ws/", "nombreCompleto");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: ws
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link NombreCompletoResponse }
     * 
     */
    public NombreCompletoResponse createNombreCompletoResponse() {
        return new NombreCompletoResponse();
    }

    /**
     * Create an instance of {@link NombreCompleto }
     * 
     */
    public NombreCompleto createNombreCompleto() {
        return new NombreCompleto();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link NombreCompletoResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws/", name = "nombreCompletoResponse")
    public JAXBElement<NombreCompletoResponse> createNombreCompletoResponse(NombreCompletoResponse value) {
        return new JAXBElement<NombreCompletoResponse>(_NombreCompletoResponse_QNAME, NombreCompletoResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link NombreCompleto }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws/", name = "nombreCompleto")
    public JAXBElement<NombreCompleto> createNombreCompleto(NombreCompleto value) {
        return new JAXBElement<NombreCompleto>(_NombreCompleto_QNAME, NombreCompleto.class, null, value);
    }

}
