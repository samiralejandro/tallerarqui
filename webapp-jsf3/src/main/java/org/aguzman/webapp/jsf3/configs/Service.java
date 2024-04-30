package org.aguzman.webapp.jsf3.configs;

import jakarta.enterprise.inject.Stereotype;
import jakarta.inject.Named;
import org.aguzman.webapp.jsf3.interceptors.Logging;


import java.lang.annotation.ElementType;
import java.lang.annotation.Retention;
import java.lang.annotation.RetentionPolicy;
import java.lang.annotation.Target;

//@RequestScoped
@Logging
@Stereotype
@Named
@Target(ElementType.TYPE)
@Retention(RetentionPolicy.RUNTIME)
public @interface Service {
}
